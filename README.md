# EventEase-Blazor

```
EventEase_Blazor/
│
├── wwwroot/                      # Static files (CSS, JS, images, etc.)
│
├── Components/                  # Reusable Blazor components
│   ├── EventCard.razor         # Displays event details
│   └── RegistrationForm.razor  # Form for user registration
│
├── Pages/                       # Routed pages of the app
│   ├── Home.razor              # Home/landing page
│   ├── Events.razor            # Event listing page
│   └── AttendanceTracker.razor # Tracks user attendance (requires login)
│
├── Models/                      # Data models
│   ├── EventModel.cs           # Represents an event
│   └── RegistrationData.cs     # Holds form data for registration
│
├── Services/                    # Application services
│   └── UserSessionService.cs   # Manages current user session
│
├── Program.cs                   # App entry point and service registration
├── App.razor                    # Sets up routing and app layout
├── index.html                   # Main HTML host (under wwwroot)
├── EventEase_Blazor.csproj      # Project configuration file
└── README.md                    # Project documentation

```

# EventEase Blazor App

## Project Overview
A corporate event management app built with Blazor WebAssembly, featuring:
- Event browsing with cards
- User registration with validation
- Session state management
- Attendance tracking

## How Copilot Assisted
| Activity | Copilot Contribution |
|----------|-----------------------|
| 1        | Generated `EventCard` boilerplate and routing |
| 2        | Suggested `@key` for performance fixes |
| 3        | Authored validation logic for forms |

## Deployment
1. **Azure Static Web Apps**:  
   ```bash
   az staticwebapp create --name EventEase --source .