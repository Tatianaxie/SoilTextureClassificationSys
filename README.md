# SoilTextureClassificationSys
Purpose: This soil texture classification categorizes soils based on the proportions of clay, silt, and sand, forming the basis for soil surveys and mapping. The method mainly involves: (1) projecting sample points according to the percentage composition of soil particles, (2) retrieving the grayscale value at the projected location, and (3) performing a hash table lookup to identify the corresponding soil texture type. This approach simplifies traditional vector-based processes and significantly enhances classification efficiency and system reusability.

## Program Structure

- **`.sln` file**: This is the main solution file of the program. It is recommended to open it using **Microsoft Visual Studio 2019**.
- **`testdata/` folder**: Contains the test datasets used for the program.
- **`source/` folder**: Includes the soil texture triangle graph used in the analysis.

## System Configuration

The experiment and program were run on a computer with the following configuration:

- **CPU**: Intel(R) Core(TM) i7-10750H @ 2.60GHz  
- **Operating System**: Windows 10 Professional  
- **Software**: Microsoft Visual Studio 2019  
- **Graph Construction**: Adobe Illustrator 2019  

## Programming and Data

- **Programming Language**: C#  
- **Input/Output Data Format**: CSV (Comma-Separated Values)  

## Usage

1. Open the `.sln` file in Visual Studio 2019.  
2. Place your input CSV files in the appropriate folder (or use the provided test data).  
3. Run the program to generate the output results.  
4. Refer to the `source/` folder for required graphical resources, such as the soil texture triangle graph.
