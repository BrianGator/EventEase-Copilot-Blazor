# EventEase Copilot Blazor

Written by Brian McCarthy

## Project Name

**EventEase Copilot Blazor**

## Website Name

**EventEase**

## Project Overview

EventEase is a Blazor event management web application created with Microsoft Copilot assistance. The app allows users to browse events, view details, register for events, track user session information, and monitor attendance records.

This project covers three activities:

1. Generate foundational Blazor components using Microsoft Copilot.
2. Debug and optimize routing, validation, and rendering performance.
3. Add advanced features including form validation, state management, and attendance tracking.

## Languages Used

- C#
- Razor
- HTML
- CSS

## Technologies Used

- Blazor
- .NET 8
- Razor Components
- Bootstrap-style CSS structure
- Dependency Injection
- Data Annotations Validation
- GitHub
- Microsoft Copilot

## Methodologies Used

- Component-based development
- Object-oriented programming
- Separation of concerns
- Service-based architecture
- Form validation using data annotations
- State management using scoped services
- Mock-data-driven development
- Defensive programming
- Routing validation and error handling
- Performance optimization using Blazor `@key`

## Requirements

To run this project locally, install:

- .NET 8 SDK or later
- Visual Studio 2022, Visual Studio Code, or GitHub Codespaces
- Git
- A modern browser such as Microsoft Edge, Chrome, or Firefox

## File Structure

```text
EventEase-Copilot-Blazor/
│
├── Components/
│   ├── App.razor
│   ├── Routes.razor
│   ├── _Imports.razor
│   ├── EventCard.razor
│   │
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   │
│   └── Pages/
│       ├── Home.razor
│       ├── EventDetails.razor
│       ├── Register.razor
│       ├── Attendance.razor
│       └── NotFound.razor
│
├── Models/
│   ├── EventModel.cs
│   ├── RegistrationModel.cs
│   └── AttendanceRecord.cs
│
├── Services/
│   ├── EventService.cs
│   ├── SessionService.cs
│   └── AttendanceService.cs
│
├── wwwroot/
│   └── app.css
│
├── EventEase-Copilot-Blazor.csproj
├── Program.cs
├── .gitignore
└── README.md
```

## How to Use

1. Clone the repository:

```bash
git clone https://github.com/BrianGator/EventEase-Copilot-Blazor.git
```

2. Navigate into the project folder:

```bash
cd EventEase-Copilot-Blazor
```

3. Restore dependencies:

```bash
dotnet restore
```

4. Build the project:

```bash
dotnet build
```

5. Run the application:

```bash
dotnet run
```

6. Open the localhost URL shown in the terminal.

7. Use the navigation menu to browse events, view event details, register for an event, and review attendance records.

## Main Functions and Features

### Event Browsing

Users can view a list of available events on the home page. Each event displays a name, date, location, and navigation buttons.

### Event Details

Users can open a details page for each event. The details page displays the event description and provides a registration link.

### Registration Form

Users can register for an event using a form that validates name, email, and phone number.

### User Session Tracking

The app stores the current registered user's name and email in a scoped session service.

### Attendance Tracker

Each successful registration creates an attendance record. The attendance page displays all registered attendees.

### Invalid Route Handling

Invalid pages are handled gracefully using a custom NotFound component.

### Performance Optimization

The event list uses the Blazor `@key` directive to help Blazor track rendered elements efficiently when lists grow or change.

## Code Examples

### Event Card Component

```razor
@using EventEase_Copilot_Blazor.Models

<div class="event-card">
    <h3>@Event.EventName</h3>
    <p><strong>Date:</strong> @Event.EventDate.ToString("MMMM dd, yyyy")</p>
    <p><strong>Location:</strong> @Event.Location</p>
    <a class="btn" href="/events/@Event.Id">View Details</a>
    <a class="btn success" href="/register/@Event.Id">Register</a>
</div>

@code {
    [Parameter]
    public EventModel Event { get; set; } = new();
}
```

### Registration Validation Model

```csharp
using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required.")]
    public string PhoneNumber { get; set; } = string.Empty;
}
```

### Attendance Service

```csharp
public class AttendanceService
{
    private readonly List<AttendanceRecord> attendanceRecords = new();

    public void AddAttendance(AttendanceRecord record)
    {
        attendanceRecords.Add(record);
    }

    public List<AttendanceRecord> GetAttendanceRecords()
    {
        return attendanceRecords;
    }
}
```

## How the Code Works

The application uses Blazor components to separate the user interface into reusable parts. The `EventCard` component receives an `EventModel` object as a parameter and displays the event information dynamically.

The `EventService` stores mock event data and provides methods to retrieve all events or find one event by ID. This keeps event data logic separate from the page components.

The `Register` page uses an `EditForm` connected to a `RegistrationModel`. Data annotations validate user input before a registration is accepted. When the form is valid, the app saves the user session through `SessionService` and adds an attendance record through `AttendanceService`.

The `Attendance` page reads saved attendance records and displays them in a table. The `SessionService` shows the current registered user, demonstrating basic state management.

Routing is handled by `Routes.razor`. Valid pages render normally, while invalid URLs display the custom `NotFound` page. This prevents the application from failing when users navigate to missing routes.

The main layout includes a footer with the text **Written by Brian McCarthy**, so the attribution appears on every page of the website.

## Microsoft Copilot Assistance Summary

Microsoft Copilot assisted with generating the foundational Event Card component, including fields for event name, date, and location. It helped suggest Blazor binding syntax, routing paths, component parameters, and mock data structure.

During debugging and optimization, Copilot helped identify missing validation, invalid route handling, and performance concerns in event rendering. The code was improved with data annotations, a custom NotFound page, null checks, and the `@key` directive.

For the final activity, Copilot helped design the Registration Form, SessionService, and AttendanceService. It also supported organizing the project into models, services, pages, and reusable components for cleaner maintainability and deployment readiness.

## Author

Written by Brian McCarthy
