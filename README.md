# ComputerUseWpfDemo

Minimal WPF application for testing Computer Use / GUI automation.

## Requirements
- Windows 10/11
- .NET 8 SDK

## Run
```powershell
cd ComputerUseWpfDemo
dotnet run
```

## Expected GUI test
1. Start the app.
2. Confirm the window title is `Computer Use WPF Demo`.
3. Click the large center button `CLICK ME`.
4. Confirm the status text changes from `Ready` to `Clicked: 1`.
5. Confirm the button label changes to `CLICKED!`.

## Example Computer Use instruction
Open the WPF application if it is not already open. Find the large button labeled "CLICK ME" in the center of the window and click it once. Verify that the text above the button becomes "Clicked: 1". Stop and report success if the text is visible; otherwise report what is shown on screen.
