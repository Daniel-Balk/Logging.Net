# Logging.Net

A logger library for C#

## Documentation

### import the logger class
```csharp
using Logging.Net;
```

### write logs to a file
```csharp
// the logs should be written to a file
Logger.LogToFile("info.log");
```

### log like blazor
```csharp
// use a blazor like logger
Logger.UseMBLogger();
```

### log with square brackets
```csharp
// use a square bracket logger
Logger.UseSBLogger();
```

### log a debug message
```csharp
// log a message as debug
Logger.Debug("A debug log message...");
```

### log an info message
```csharp
// log a message as info
Logger.Log("A log message...");
```

or

```csharp
// Logger.Info(message) == Logger.Log(message)
Logger.Info("Another log message...");
```

### log a warning message
```csharp
// log a message as warning
Logger.Warn("A warning message...");
```

### log an error message
```csharp
// log a message as an error
Logger.Error("A error message..");
```
