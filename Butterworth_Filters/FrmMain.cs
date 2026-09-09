using System;
using System.Windows.Forms;
using System.IO;

namespace Butterworth_Filters
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void RbBandPass_CheckedChanged(object sender, EventArgs e)
        {
            if (RbBandPass.Checked)
            {
                LblOpt1.Text = "Bottom Frequency";
                LblOpt2.Text = "Top Frequency";
                LblOpt3.Text = "Sections";
                LblOpt3.Visible = true; 
                LblHzOpt2.Visible = true;
                TbOpt1.Text = "0.1";
                TbOpt2.Text = "1.6";
                TbOpt3.Text = "20";
                TbOpt3.Visible = true;
            }
        }

        private void RbHighPass_CheckedChanged(object sender, EventArgs e)
        {
            if (RbHighPass.Checked)
            {
                LblOpt1.Text = "Cutoff Frequency";
                LblOpt2.Text = "Sections";
                LblOpt3.Visible = false;
                LblHzOpt2.Visible = false;
                TbOpt1.Text = "1.6";
                TbOpt2.Text = "20";
                TbOpt3.Visible = false;
            }
        }

        private void RbLowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (RbLowPass.Checked)
            {
                LblOpt1.Text = "Cutoff Frequency";
                LblOpt2.Text = "Sections";
                LblOpt3.Visible = false;
                LblHzOpt2.Visible = false;
                TbOpt1.Text = "1.6";
                TbOpt2.Text = "20";
                TbOpt3.Visible = false;
            }
        }

        private void BtnFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            if (OFD.ShowDialog() == DialogResult.OK) TbFilename.Text = OFD.FileName;
            OFD.Dispose();
        }

        private void All_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void All_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] MyFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(MyFiles[0])) TbFilename.Text = MyFiles[0];
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            double[] InputData;
            double[] OutputData = { 0 }; 
            string Line_O_Text, OutputFile, Header;
            int Counter = 0;
            int DataCounter = 1;
            string[] Split_Line;
            int Column_Num = int.Parse(TbColumnNum.Text) - 1;

            try
            {
                if (!File.Exists(TbFilename.Text))
                {
                    LbOutput.Items.Add("File Not Found");
                    return;
                }

                //Lets get how many lines there are in the file. - Assuming they all have data....
                int LineCount = File.ReadAllLines(TbFilename.Text).Length;
                if (CbHeader.Checked) InputData = new double[LineCount - 1];
                else InputData = new double[LineCount];
                progressBar1.Maximum = LineCount;

                OutputFile = new FileInfo(TbFilename.Text).FullName.Replace(new FileInfo(TbFilename.Text).Extension, "_out.csv");
                //Load the file
                StreamReader InputFile = new StreamReader(TbFilename.Text);
                while ((Line_O_Text = InputFile.ReadLine()) != null)
                {
                    Counter++;
                    if ((!CbHeader.Checked) || Counter != 1)
                    {
                        Split_Line = Line_O_Text.Split(',');
                        if (Split_Line.Length < int.Parse(TbColumnNum.Text))
                        {
                            LbOutput.Items.Add("Error: Not enough columns on line " + Counter.ToString());
                            LbOutput.Items.Add("Stopped processing.");
                            return;
                        }
                        progressBar1.Value = DataCounter;
                        Application.DoEvents();
                        InputData[DataCounter - 1] = double.Parse(Split_Line[Column_Num]);
                        DataCounter++;
                    }
                }
                InputFile.Close();
                Array.Resize(ref OutputData, InputData.Length);

                if (RbLowPass.Checked)
                {
                    LowpassFilterButterworthImplementation LPFilter = new LowpassFilterButterworthImplementation(double.Parse(TbOpt1.Text), int.Parse(TbOpt2.Text), double.Parse(TbInputHz.Text));
                    Header = "LowPass_" + TbOpt1.Text + "_" + TbOpt2.Text;
                    for (int i = 0; i < InputData.Length - 1; i++)
                    {
                        OutputData[i] = LPFilter.Compute(InputData[i]);
                    }
                }
                else if (RbHighPass.Checked)
                {
                    HighpassFilterButterworthImplementation HPFilter = new HighpassFilterButterworthImplementation(double.Parse(TbOpt1.Text), int.Parse(TbOpt2.Text), double.Parse(TbInputHz.Text));
                    Header = "HighPass_" + TbOpt1.Text + "_" + TbOpt2.Text;
                    for (int i = 0; i < InputData.Length - 1; i++)
                    {
                        OutputData[i] = HPFilter.Compute(InputData[i]);
                    }
                }
                else
                {
                    BandpassFilterButterworthImplementation BPFilter = new BandpassFilterButterworthImplementation(double.Parse(TbOpt1.Text), double.Parse(TbOpt2.Text), int.Parse(TbOpt3.Text), double.Parse(TbInputHz.Text));
                    Header = "BandPass_" + TbOpt1.Text + "_" + TbOpt2.Text + "_" + TbOpt3.Text;
                    for (int i = 0; i < InputData.Length - 1; i++)
                    {
                        OutputData[i] = BPFilter.Compute(InputData[i]);
                    }
                }
                //save the output
                StreamWriter OutPutStream = new StreamWriter(OutputFile, false, System.Text.Encoding.ASCII);
                OutPutStream.WriteLine(Header);
                for (int i = 0; i < OutputData.Length - 1; i++)
                {
                    OutPutStream.WriteLine(OutputData[i].ToString());
                }
                OutPutStream.Close();
                LbOutput.Items.Add("File Saved : " + OutputFile);
            }
            catch (Exception ex)
            {
                LbOutput.Items.Add(ex.Message);
            }
        }
    }
}
