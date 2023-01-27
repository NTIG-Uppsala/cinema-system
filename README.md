# Cinema system
A POS system for the cinema industry.

When running, the program will write receipts to the folder `PosReceipts` in the `PosSystem` folder which is located in the user's document folder.
In the `PosSystem` folder you will also find `database.db` a database containing the following tables:

- products
- movies
- screenings 
- salons
- seats
- reservations
- bookings
- customers

The program creates example data inside the `database.db` file when run. You can open the file using [DB Browser for SQLite](https://sqlitebrowser.org/dl/). alternatively you can view the database schema below.

![image](https://user-images.githubusercontent.com/111983315/215114323-627104bf-aa90-4b7c-a654-5c942cc11cb6.png)

## Setup
To set up Visual Studio for this project: run the `setup.bat` file in setup folder.

To install the client program, run the `setup.exe` file from a release.

To install the appropriate packages for sqlite, which is used to manage the database, open the `package manager console` inside visual studio and run `Install-Package Microsoft.data.sqlite`

## Install the program
To install the program, install the `Install.zip` file in releases.
Unzip the file and run the setup.exe to install the program and necessary .NET versions.
Then the program will appear on the desktop if you have icons on and it will appear in the windows start menu.
After that you can run the program!

## TODO

Upon leaving this project the team was working on integrating our GUI with the Database system. The GUI currently creates product buttons and movie tabs based on existing data within the `database.db` file. The booking system is currently hardcoded as a proof of concept. To complete the system the following needs to be implemented:

- Generate `screenings` from database and display in GUI.
- Generate `seats` from database and display in GUI.
- Add a `reservation` to database upon selecting a seat.
- Add `bookings` to database upon purchase of movie ticket.

## Contact information 

If you want to contact us regarding any issues facing you when working on this project, you can find our contact information below.

@Axelgustavschnurer
- Mail: axel.schnurer@gmail.com
- Phone: 076-135 75 53 (Will only answer texts)

@Viggoblom
- Mail: blomqvist.viggo@gmail.com
- Phone: 072-576 65 06 (Will only answer texts)

@Kasper-coder 
- Mail: holgerssonkasper@gmail.com

@Leon-Loov
- Mail: leon.loov@outlook.com

## Definition of Done
- Code should be approved by everyone present, with a minimum of 2 people.
- Everyone present should understand the project.
- Necessary parts of code should be tested by automatic tests.
- Pull requests should have a description of what they implement.
- Code should follow the [coding conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Code should be documented.
- The documentation should be up to date.
