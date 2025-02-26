# EventManager

EventManager is a Windows Forms application designed to manage events, track participants, and calculate event costs. It allows the user to create events, add participants, and manage event expenses.

## Features

### 1. Create Event
   1. The user starts by entering a title for the event, followed by the cost per participant and fee per participant.
   2. After entering the required information, the user clicks **Create Event** and the event is created with a confirmation message: **"Event created successfully!"**.

### 2. Add Participants
   The user can add participants by filling out the necessary fields:
   - First Name
   - Last Name
   - Street
   - Zip Code
   - City
   - Country

   If a required field is missing, the program will alert the user with a message informing them that the field must be filled in.

### 3. Manage Participants
   1. Once participants are added, the user can view and edit the list of participants.
   2. To edit a participant, the user clicks on the participant's name in the list, which will display their details in the fields to the left. The user can then make changes and click **Change**.
   3. To delete a participant, the user selects the participant and clicks **Delete**.

### 4. Event Economy
   The **Event Economy** section in the top-right corner updates dynamically as participants are added or removed. It calculates:
   - Number of Participants
   - Total Cost
   - Total Fees
   - Surplus/Deficit

## Installation

1. Clone the repository or download the project files.
2. Open the project in **Visual Studio 2022**.
3. Build and run the project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
