﻿using Logging.Net.Loggers;
using Logging.Net.Loggers.MB;
using Logging.Net.Loggers.SB;
using System;
using System.Reflection;

namespace Logging.Net
{
    /// <summary>
    /// A public static class to access the logger
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// The Logger the class uses
        /// </summary>
        public static ILogger UsedLogger { get; set; } = new SBLogger();

        #region Debug-Log Methods

        /// <summary>
        /// log an exception as debug
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Debug(Exception e)
        {
            UsedLogger.DebugEx(e);
        }

        /// <summary>
        /// logs an uint as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(uint value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a formated string as debug
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing parameters</param>
        public static void Debug(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Debug(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(bool value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a char[] as debug
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Debug(char[] buffer)
        {
            Debug(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as debug
        /// </summary>
        /// <param name="buffer">value to log</param>
        /// <param name="index">start at</param>
        /// <param name="count">count of chars to log</param>
        public static void Debug(char[] buffer, int index, int count)
        {
            Debug(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(decimal value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a double as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(double value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs an ulong as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(ulong value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs an int as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(int value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs an object as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(object value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a float as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(float value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a string as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(string value)
        {
            if (!DisableDebug)
                UsedLogger.Debug(value);
        }

        /// <summary>
        /// logs a long as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(long value)
        {
            Debug(value.ToString());
        }

        /// <summary>
        /// logs a char as debug
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Debug(char value)
        {
            Debug(value.ToString());
        }
        #endregion

        #region Info-Log Methods
        #region Info

        /// <summary>
        /// log an exception as info
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Info(Exception e)
        {
            UsedLogger.InfoEx(e);
        }

        /// <summary>
        /// logs an uint as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(uint value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a formated string
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing strings</param>
        public static void Info(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Info(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(bool value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a char[] as info
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Info(char[] buffer)
        {
            Info(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as info
        /// </summary>
        /// <param name="buffer">chars to log</param>
        /// <param name="index">start in buffer</param>
        /// <param name="count">count of chars to log</param>
        public static void Info(char[] buffer, int index, int count)
        {
            Info(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(decimal value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a double as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(double value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs an ulong as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(ulong value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs an int as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(int value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs an object as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(object value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a float as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(float value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a string as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(string value)
        {
            if (!DisableInfo)
                UsedLogger.Info(value);
        }

        /// <summary>
        /// logs a long as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(long value)
        {
            Info(value.ToString());
        }

        /// <summary>
        /// logs a char as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Info(char value)
        {
            Info(value.ToString());
        }

        #endregion

        // Could also be accessed with Log()

        #region Log

        /// <summary>
        /// log an exception as info
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Log(Exception e)
        {
            UsedLogger.InfoEx(e);
        }


        /// <summary>
        /// logs an uint as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(uint value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a formated string
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing strings</param>
        public static void Log(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Log(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(bool value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a char[] as info
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Log(char[] buffer)
        {
            Log(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as info
        /// </summary>
        /// <param name="buffer">chars to log</param>
        /// <param name="index">start in buffer</param>
        /// <param name="count">count of chars to log</param>
        public static void Log(char[] buffer, int index, int count)
        {
            Log(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(decimal value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a double as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(double value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs an ulong as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(ulong value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs an int as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(int value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs an object as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(object value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a float as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(float value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a string as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(string value)
        {
            if (!DisableInfo)
                UsedLogger.Info(value);
        }

        /// <summary>
        /// logs a long as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(long value)
        {
            Log(value.ToString());
        }

        /// <summary>
        /// logs a char as info
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Log(char value)
        {
            Log(value.ToString());
        }
        #endregion
        #endregion

        #region Warn-Log Methods

        /// <summary>
        /// log an exception as warn
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Warn(Exception e)
        {
            UsedLogger.WarnEx(e);
        }

        /// <summary>
        /// logs an uint as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(uint value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a formated string as warn
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing parameters</param>
        public static void Warn(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Warn(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(bool value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a char[] as warn
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Warn(char[] buffer)
        {
            Warn(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as warn
        /// </summary>
        /// <param name="buffer">value to log</param>
        /// <param name="index">start at</param>
        /// <param name="count">count of chars to log</param>
        public static void Warn(char[] buffer, int index, int count)
        {
            Warn(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(decimal value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a double as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(double value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs an ulong as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(ulong value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs an int as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(int value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs an object as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(object value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a float as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(float value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a string as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(string value)
        {
            if (!DisableWarn)
                UsedLogger.Warn(value);
        }

        /// <summary>
        /// logs a long as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(long value)
        {
            Warn(value.ToString());
        }

        /// <summary>
        /// logs a char as warn
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Warn(char value)
        {
            Warn(value.ToString());
        }
        #endregion

        #region Error-Log Methods

        /// <summary>
        /// log an exception as error
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Error(Exception e)
        {
            UsedLogger.ErrorEx(e);
        }

        /// <summary>
        /// logs an uint as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(uint value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a formated string as error
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing parameters</param>
        public static void Error(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Error(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(bool value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a char[] as error
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Error(char[] buffer)
        {
            Error(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as error
        /// </summary>
        /// <param name="buffer">value to log</param>
        /// <param name="index">start at</param>
        /// <param name="count">count of chars to log</param>
        public static void Error(char[] buffer, int index, int count)
        {
            Error(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(decimal value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a double as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(double value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs an ulong as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(ulong value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs an int as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(int value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs an object as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(object value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a float as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(float value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a string as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(string value)
        {
            if (!DisableError)
                UsedLogger.Error(value);
        }

        /// <summary>
        /// logs a long as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(long value)
        {
            Error(value.ToString());
        }

        /// <summary>
        /// logs a char as error
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Error(char value)
        {
            Error(value.ToString());
        }
        #endregion

        #region Fatal-Log Methods

        /// <summary>
        /// log an exception as fatal
        /// </summary>
        /// <param name="e">exception to log</param>
        public static void Fatal(Exception e)
        {
            UsedLogger.FatalEx(e);
        }

        /// <summary>
        /// logs an uint as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(uint value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a formated string as fatal
        /// </summary>
        /// <param name="format">base string</param>
        /// <param name="arg">replacing parameters</param>
        public static void Fatal(string format, params object[] arg)
        {
            string s = format;
            int i = 0;
            foreach (var v in arg)
            {
                if (!s.Contains($"{{{i}}}"))
                    s += $" {{{i}}}";
                i++;
            }
            Fatal(string.Format(s, arg));
        }

        /// <summary>
        /// logs a bool as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(bool value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a char[] as fatal
        /// </summary>
        /// <param name="buffer">value to log</param>
        public static void Fatal(char[] buffer)
        {
            Fatal(new string(buffer));
        }

        /// <summary>
        /// logs a part of a char[] as fatal
        /// </summary>
        /// <param name="buffer">value to log</param>
        /// <param name="index">start at</param>
        /// <param name="count">count of chars to log</param>
        public static void Fatal(char[] buffer, int index, int count)
        {
            Fatal(new string(buffer, index, count));
        }

        /// <summary>
        /// logs a decimal as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(decimal value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a double as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(double value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs an ulong as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(ulong value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs an int as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(int value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs an object as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(object value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a float as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(float value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a string as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(string value)
        {
            if (!DisableFatal)
                UsedLogger.Fatal(value);
        }

        /// <summary>
        /// logs a long as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(long value)
        {
            Fatal(value.ToString());
        }

        /// <summary>
        /// logs a char as fatal
        /// </summary>
        /// <param name="value">value to log</param>
        public static void Fatal(char value)
        {
            Fatal(value.ToString());
        }
        #endregion

        #region Logfiles and Modes

        /// <summary>
        /// tells the logger to save the logs to a specified file
        /// </summary>
        /// <param name="fileName">file, where the logs get saved</param>
        public static void LogToFile(string fileName)
        {
            UsedLogger.SetAddition(new LogFileLogger(fileName));
        }

        /// <summary>
        /// tells the logger to save the logs to a specified html file
        /// </summary>
        /// <param name="fileName">file, where the logs get saved</param>
        public static void LogToHtmlFile(string fileName)
        {
            UsedLogger.SetAddition(new HTMLFileLogger(fileName));
        }

        /// <summary>
        /// use a blazor like logger
        /// </summary>
        public static void UseMBLogger()
        {
            UsedLogger = new MBLogger();
        }

        /// <summary>
        /// use a spuare bracket logger
        /// </summary>
        public static void UseSBLogger()
        {
            UsedLogger = new SBLogger();
        }

        #endregion

        #region Loglevels

        /// <summary>
        /// by setting this to true, the logger wont log debug anymore
        /// </summary>
        public static bool DisableDebug { get; set; } = false;

        /// <summary>
        /// by setting this to true, the logger wont log info anymore
        /// </summary>
        public static bool DisableInfo { get; set; } = false;

        /// <summary>
        /// by setting this to true, the logger wont log warn anymore
        /// </summary>
        public static bool DisableWarn { get; set; } = false;

        /// <summary>
        /// by setting this to true, the logger wont log error anymore
        /// </summary>
        public static bool DisableError { get; set; } = false;

        /// <summary>
        /// by setting this to true, the logger wont log fatal anymore
        /// </summary>
        public static bool DisableFatal { get; set; } = false;

        #endregion
    }
}