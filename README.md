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
- YAML

## Technologies Used

- Blazor
- .NET 8
- Razor Components
- Dependency Injection
- GitHub Actions
- Microsoft Copilot
- GitHub

## Methodologies Used

- Component-based development
- Object-oriented programming
- Separation of concerns
- Service-based architecture
- Manual form validation
- State management using scoped services
- Mock-data-driven development
- Defensive programming
- Routing validation and error handling
- Performance optimization using Blazor `@key`
- Continuous integration with GitHub Actions

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
│   ├── RegistrationInfo.cs
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
├── .github/workflows/
│   └── dotnet-build.yml
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

Users can register for an event using a form that validates name, email, and phone number before the app records attendance.

### User Session Tracking

The app stores the current registered user's name and email in a scoped session service.

### Attendance Tracker

Each successful registration creates an attendance record. The attendance page displays all registered attendees.

### Invalid Route Handling

Invalid pages are handled gracefully using a custom NotFound component.

### Performance Optimization

The event list uses the Blazor `@key` directive to help Blazor track rendered elements efficiently when lists grow or change.

### Build Automation

The repository includes a GitHub Actions workflow that restores dependencies and builds the .NET project on push and pull request events.

## Code Examples

### Event Card Component

```razor
@using EventEase_Copilot_Blazor.Models

<div class="event-card">
    <h3>@Event.EventName</h3>
    <p><strong>Date:</strong> @Event.EventDate.ToString("MMMM dd, yyyy")</p>
    <p><strong>Location:</strong> @Event.Location</p>
    <div class="button-row">
        <a class="btn" href="/events/@Event.Id">View Details</a>
        <a class="btn success" href="/register/@Event.Id">Register</a>
    </div>
    <p class="author-line">Written by Brian McCarthy</p>
</div>

@code {
    [Parameter]
    public EventModel Event { get; set; } = new();
}
```

### Registration Model

```csharp
public class RegistrationInfo
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ContactNumber { get; set; } = string.Empty;
}
```

### Registration Validation Logic

```csharp
if (string.IsNullOrWhiteSpace(registration.Name) ||
    string.IsNullOrWhiteSpace(registration.Email) ||
    string.IsNullOrWhiteSpace(registration.ContactNumber))
{
    errorMessage = "Please complete all registration fields.";
    return;
}

if (!registration.Email.Contains('@'))
{
    errorMessage = "Please enter a valid email address.";
    return;
}
```

### Attendance Service

```csharp
public class AttendanceService
{
    private readonly List<AttendanceRecord> records = new();

    public void AddRecord(AttendanceRecord record)
    {
        records.Add(record);
    }

    public List<AttendanceRecord> GetRecords()
    {
        return records;
    }
}
```

## How the Code Works

The application uses Blazor components to separate the user interface into reusable parts. The `EventCard` component receives an `EventModel` object as a parameter and displays event information dynamically.

The `EventService` stores mock event data and provides methods to retrieve all events or find one event by ID. This keeps event data logic separate from the page components.

The `Register` page uses an `EditForm` connected to a `RegistrationInfo` model. The page checks for empty fields and validates that the email contains an `@` symbol before accepting the registration. When the form is valid, the app saves the user session through `SessionService` and adds an attendance record through `AttendanceService`.

The `Attendance` page reads saved attendance records and displays them in a table. The `SessionService` shows the current registered user, demonstrating basic state management.

Routing is handled by `Routes.razor`. Valid pages render normally, while invalid URLs display the custom `NotFound` page. This prevents the application from failing when users navigate to missing routes.

Each page and the Event Card component include **Written by Brian McCarthy**, so the attribution appears throughout the website.

## Microsoft Copilot Assistance Summary

Microsoft Copilot assisted with generating the foundational Event Card component, including fields for event name, date, and location. It helped suggest Blazor binding syntax, routing paths, component parameters, and mock data structure.

During debugging and optimization, Copilot helped identify missing validation, invalid route handling, and performance concerns in event rendering. The code was improved with validation checks, a custom NotFound page, null checks, and the `@key` directive.

For the final activity, Copilot helped design the Registration Form, SessionService, and AttendanceService. It also supported organizing the project into models, services, pages, and reusable components for cleaner maintainability and deployment readiness.

## Author

Written by Brian McCarthy
