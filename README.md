# GazlVolunteer

GazlVolunteer is a .NET 8 and SQL Server-based project designed to facilitate voluntary services in the city of Bisha. This project allows different types of users to interact with the system to provide, request, and manage services and opportunities within the community.

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Acknowledgements](#acknowledgements)

## Description

GazlVolunteer is a volunteer management platform with four types of users:

1. **Visitor**: Can view news and places on the map.
2. **Civil Organization**: Can add homes that need services on the map and create volunteer opportunities.
3. **Government Agency**: Can view services, add notifications for users, and manage community needs.
4. **Visitor and Government Agency**: Can both complement each other's roles in terms of visibility and service management.

### Key Features

- **Authentication**: Registration with email confirmation, login, password reset, OTP verification, and forget password functionality.
- **Map Integration**: Users can interact with a map to add and view locations that require services.
- **Notifications**: Government Agencies can send notifications to all users.
- **Volunteer Opportunities**: Civil Organizations can create and manage volunteer opportunities.

## Installation

To set up GazlVolunteer locally, follow these steps:

1. **Clone the repository**:
    ```sh
    git clone https://github.com/yourusername/GazlVolunteer.git
    cd GazlVolunteer
    ```

2. **Install dependencies**:
    Ensure you have .NET 8 SDK and SQL Server installed on your machine.

3. **Configure the database**:
    - Create a SQL Server database.
    - Update the connection string in `appsettings.json` to point to your database.

4. **Run the project**:
    ```sh
    dotnet build
    dotnet run
    ```

## Usage

Once the project is running, you can interact with it as follows:

1. **Register an account** and verify your email.
2. **Login** to access your dashboard.
3. **Visitors** can explore news and places on the map.
4. **Civil Organizations** can add homes needing services and create volunteer opportunities.
5. **Government Agencies** can view and manage service requests, add notifications, and monitor community needs.
6. **Notifications**: Government Agencies can send notifications to all users.
7. **Manage Opportunities**: Civil Organizations can manage volunteer opportunities and track participation.

## Contributing

We welcome contributions to GazlVolunteer! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a pull request.

Please ensure your code adheres to our coding standards and include tests where appropriate.

## License

GazlVolunteer is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For questions or support, please contact the project maintainers at [your-email@example.com].

## Acknowledgements

- Thanks to all contributors and the community for their support and feedback.
- Special thanks to the developers and organizations that have provided invaluable resources and inspiration for this project.
