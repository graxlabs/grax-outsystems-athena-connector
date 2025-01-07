# GRAX Athena Connector

GRAX Athena Connector is a C# project designed to facilitate integration with Amazon Athena for querying and managing data efficiently. The code is optimized to be used on the OutSystems Platform.

## Installation

- Clone the repository or download the source code.
- Open the GRAX_AthenaConnector.sln solution file in Visual Studio.
- Ensure you have the required dependencies installed. You can restore NuGet packages by running:

```bash
nuget restore GRAX_AthenaConnector.sln
```

- Build the project to resolve dependencies and create the executable or library.

## Usage

### Integration

- Include the compiled library in your .NET project.
- Reference the namespace GRAX_AthenaConnector to use the provided functionalities.

## Sample Code

Here’s a basic example of how to use the connector:

```csharp
using GRAX_AthenaConnector;

public class Example
{
    public void ExecuteQuery()
    {
        var connector = new AthenaConnector();
        connector.Execute("SELECT * FROM sample_table");
    }
}
```

## Configuration

Edit the app.config file to set up any required configurations such as connection strings or API keys.

## Project Structure

- AmazonAthena: Contains components related to Amazon Athena integration.
- Bin: Compiled binaries (output directory).
- obj: Intermediate build files.
- packages: NuGet packages used by the project.
- .cs files: Core C# files defining the connector, entities, interfaces, and utility methods.
app.config: Configuration file for runtime settings.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Make sure to:

- Follow the coding conventions used in the project.
- Update/add relevant tests for new functionality.

## References

- AWSSDK.Athena (https://www.nuget.org/packages/AWSSDK.Athena/) - Apache 2.0
- AESSDK.Core (https://www.nuget.org/packages/AWSSDK.Core/4.0.0-preview.4) - Apache 2.0

# License

This project is licensed under the MIT license.