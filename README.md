**THIS PROJECT IS A WORK IN PROGRESS**

# C# Excel Query

C# library for recording queries

## How to Use

*See the included example project to see it in action*

## Logging

The library supports injecting a logger object to be used to log issues using the API.
To avoid dependencies on any particular logging library, the logger instance used should implement the `ExcelQuery.Log.ILogger` interface.

To inject a logger:

```csharp
IExcelQueryApi api = new ExcelQueryApiImpl();
ILogger logger = // ...
api.SetLogger(logger);
```

The logger can be set to `null` to disable logging.
