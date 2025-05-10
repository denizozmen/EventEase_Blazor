# EventEase-Blazor

```
EventEase-Blazor/
├── .github/
│   └── workflows/
│       └── deploy.yml          # CI/CD for Azure Static Web Apps
├── Client/
│   ├── wwwroot/                # Static files
│   ├── Components/
│   │   ├── EventCard.razor     # (Activity 1)
│   │   ├── EventCard.razor.css
│   │   ├── RegistrationForm.razor  # (Activity 3)
│   │   └── AttendanceTracker.razor
│   ├── Pages/
│   │   ├── Events.razor        # Event list (Activity 1)
│   │   ├── EventDetails.razor  # (Activity 1)
│   │   └── Register.razor      # (Activity 3)
│   ├── Services/
│   │   └── UserSessionService.cs  # (Activity 3)
│   ├── Models/
│   │   └── EventModel.cs       # Data model (Activity 1)
│   └── Program.cs              # DI registrations (Activity 3)
├── README.md                   # Project summary + Copilot usage
└── EventEase-Blazor.sln
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