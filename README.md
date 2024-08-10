# Meet_Final_Of_MAUIApp

## Project Overview

**Meet_Final_Of_MAUIApp** is a MAUI desktop application designed to manage concert events. The application connects to a database to store and retrieve event information, providing a user-friendly graphical user interface (GUI) for interaction. This project integrates various elements from previous assignments to create a cohesive and functional application.

## Technologies Used

- **.NET MAUI**: For creating the cross-platform GUI.
- **C#**: The primary programming language used.
- **MySQL**: For database management.
- **Visual Studio IDE**: The development environment.
- **GitHub**: For version control and collaboration.

## Project Goals

### Initial Goals

1. Develop a MAUI desktop application.
2. Implement database connectivity to manage concert events.
3. Create a user-friendly GUI for CRUD operations on concert events.
4. Ensure the application is robust with proper error handling and validation.

### Achieved Goals

1. Successfully developed a MAUI desktop application.
2. Implemented SQLite database for storing concert events.
3. Created a functional and intuitive GUI for managing events.
4. Achieved robust error handling and input validation.

## Functionality

### Core Features

- **Event Management**: Add, update, delete, and view concert events.
- **Database Integration**: Store and retrieve event data using SQLite.
- **User Interface**: Intuitive MAUI-based GUI for easy interaction.
- **Error Handling**: Comprehensive exception handling to ensure application stability.
- **Input Validation**: Ensures all user inputs are valid and secure.

## Classes and Inheritance

### Key Classes

- **Event**: Represents a concert event with properties like `EventId`, `Name`, `Date`, `Location`, and `Description`.
- **DatabaseManager**: Handles database operations like connecting, querying, and updating the SQLite database.
- **EventViewModel**: Manages the data binding between the GUI and the event data.

### Inheritance and Interfaces

- **BaseViewModel**: A base class for view models to implement common functionality.
- **IEventRepository**: An interface defining methods for event data operations, implemented by `EventRepository`.

## MAUI GUI

The user interface is built using MAUI, providing a cross-platform experience. Key UI components include:

- **Main Page**: Displays a list of events with options to add, edit, or delete events.
- **Event Form**: A form for entering event details, used for both adding and editing events.
- **Navigation**: Simple and intuitive navigation between different pages.

## Exception Handling

The application uses try-catch blocks to handle exceptions and provide meaningful error messages to the user. Examples include:

- **Database Connection Errors**: Handled to ensure the application can gracefully notify the user of connection issues.
- **Input Validation Errors**: Ensures user inputs are valid and provides feedback for corrections.

## Conclusion

This project successfully integrates various aspects of software development, from database management to GUI design and error handling. The goals set out at the beginning were achieved, resulting in a functional and user-friendly application. Future improvements could include adding more features, optimizing performance, and enhancing the user interface.

## How to Run the Project

1. Clone the repository from GitHub.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build and run the application.

## Repository Structure

- **/Meet_Final_Of_MAUIApp**: Main project directory.
  - **/Models**: Contains data models like `Event`.
  - **/ViewModels**: Contains view models like `EventViewModel`.
  - **/Views**: Contains UI pages like `MainPage` and `EventFormPage`.
  - **/Services**: Contains services like `DatabaseManager`.
  - **App.xaml**: Application configuration.
  - **MainPage.xaml**: Main page layout.

## Contributions

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.
