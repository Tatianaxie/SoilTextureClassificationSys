# SoilTextureClassificationSys
Purpose: This soil texture classification categorizes soils based on the proportions of clay, silt, and sand, forming the basis for soil surveys and mapping. The method mainly involves: (1) projecting sample points according to the percentage composition of soil particles, (2) retrieving the grayscale value at the projected location, and (3) performing a hash table lookup to identify the corresponding soil texture type. This approach simplifies traditional vector-based processes and significantly enhances classification efficiency and system reusability.

## Program Structure

- **`.sln` file**: This is the main solution file of the program. It is recommended to open it using **Microsoft Visual Studio 2019**.
- **`testdata/` folder**: Contains the test datasets used for the program.
- **`source/` folder**: Includes the soil texture triangle graph used in the analysis.

## Programming and Data

- **Programming Language**: C#  
- **Input/Output Data Format**: CSV (Comma-Separated Values)  

