# CookBookProjectWithWinForm

This project is a Windows Forms application for managing and viewing recipes. It offers various features to manage and display recipes effectively. Additionally, the project utilizes Dapper for database interactions and follows best practices in software architecture.

## Features

- **Recipe Management**: Add, edit, and delete recipes.
- **Ingredient Management**: Sort ingredients by name.
- **Form Navigation**: Navigate between different forms.
- **Search Functionality**: Search through recipes.
- **Asynchronous Operations**: Improved user experience with asynchronous programming.
- **Exception and Error Handling**: Comprehensive system for handling exceptions and errors.
- **Observer Design Pattern**: Implemented to track changes.
- **Dependency Injection**: Used throughout the project to enhance modularity and testability.
- **Database Constraints**: Added for database integrity.

## Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/user/CookBookProjectWithWinForm.git
   cd CookBookProjectWithWinForm
   ```

2. **Install Dependencies**
   The project will automatically install the necessary dependencies using the NuGet package manager.

3. **Database Configuration**
   Add your database connection string to the `appsettings.json` file.

## Usage

1. **Run the Application**
   Open the project in Visual Studio or a similar IDE and run it.

2. **Add a Recipe**
   Click the "Add Recipe" button to add a new recipe.

3. **View and Edit Recipes**
   View and edit existing recipes in the "Recipes" form.

4. **Manage Ingredients**
   View ingredients and sort them by name.

## Technology Used

- **Dapper**: Used for efficient and simple database operations.
- **Layered Architecture**: The project follows a layered architecture to separate concerns, making the codebase more maintainable and scalable.
  - **Presentation Layer**: Handles the user interface and user interactions.
  - **Business Logic Layer**: Contains the business rules and logic.
  - **Data Access Layer**: Manages data persistence and retrieval.
- **Repository Design Pattern**: Implemented to abstract data access logic and promote a clean separation of concerns.
- **Dependency Injection**: Used to inject dependencies, making the code more modular and easier to test.
- **Observer Design Pattern**: Utilized to notify changes and update views accordingly.

## Contributing

If you would like to contribute, please open a pull request or submit an issue.

## License

This project is licensed under the MIT License. For more information, see the LICENSE file.

---

For any questions or feedback, please contact us.

Thank you!

Mehmet Albayrak
