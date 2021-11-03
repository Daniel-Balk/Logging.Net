# Logging.Net
[![Logging.Net on nuget.org](https://img.shields.io/badge/nuget-v1.0.0-blue.svg)](https://www.nuget.org/packages/Logging.Net/)
[![License: GNU GPL](https://img.shields.io/badge/License-GNU_GPL_v3-green.svg)](https://github.com/Dalk-Github/Logging.Net/blob/master/LICENSE)

A logger library for C#

## Documentation

### write logs to a file
```csharp
// the logs should be written to a file
Logger.LogToFile("info.log");
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
