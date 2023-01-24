# Cinema system
A POS system for the cinema industry.

When running, the program will write receipts to the folder `PosReceipts` in the `PosSystem` folder which is located in the user's document folder.
In the `PosSystem` folder you will also find `movies.csv` and `products.csv` where the data of the movies and products are stored. Meaning you can customize what products and movies the PosSystem is selling, how much they cost and the color of the buttons.

## Setup
To set up Visual Studio for this project: run the `setup.bat` file in setup folder.

To install the client program, run the `setup.exe` file from a release.

To install the appropriate packages for sqlite, open the `package manager console` inside visual studio and run `Install-Package Microsoft.data.sqlite`

## Install the program
To install the program, install the `Install.zip` file in releases.
Unzip the file and run the setup.exe to install the program and necessary .NET versions.
Then the program will appear on the desktop if you have icons on and it will appear in the windows start menu.
After that you can run the program!

## Definition of Done
- Code should be approved by everyone present, with a minimum of 2 people.
- Everyone present should understand the project.
- Necessary parts of code should be tested by automatic tests.
- Pull requests should have a description of what they implement.
- Code should follow the [coding conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Code should be documented.
- The documentation should be up to date.
