# Venue Api

The back end portion of the tech test. Exposes Leeds beer quest data through a RESTful API.

## Running the application

### Dependencies

This application requires .NET Core 3.1.

### How to start the application

Navigate to the root of the project and run `dotnet build`. This will restore all nuget dependencies and build the application.
You can then navigate to the nested `XLabs.Venue.Api` directory and run `dotnet run` to run the application. You can then visit `https://localhost:5001/venues` to retrieve a list of venues.

## Running the tests

From the root directory, run `dotnet test` to run all tests.
