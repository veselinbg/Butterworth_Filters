# Butterworth Filters

A Windows Forms tool that applies digital Butterworth filters to a column of data in a CSV file.

## Features

- **Low-pass**, **high-pass** and **band-pass** Butterworth filters
- Configurable cutoff frequency (or bottom/top frequency for band-pass), number of sections and input sample rate
- Filters are built from cascaded second-order sections (bilinear transform), each made of an FIR and an IIR part
- Pick the column to filter; optional header row
- Drag and drop a file onto the window
- Writes the result to `<input>_out.csv` next to the input file

## Run

Open `Butterworth_Filters.sln` in Visual Studio and run it (.NET Framework 4.7.2).

## Tech stack

C# · .NET Framework 4.7.2 · WinForms · digital signal processing
