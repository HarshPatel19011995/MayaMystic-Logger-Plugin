/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLogger.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Core runtime logger system for the MayaMystic Logger framework.
 *  Handles log creation, metadata generation,
 *  formatting, and Unity console output routing.
 * 
 **************************************************************************/

using System;
using System.IO;
using System.Runtime.CompilerServices;
using MayaMystic.Logger.Models;
using MayaMystic.Logger.Utilities;
using UnityEngine;

namespace MayaMystic.Logger.Core
{
	/// <summary>
	/// Core runtime logger system for the MayaMystic Logger framework.
	/// </summary>
	/// <remarks>
	/// Responsible for:
	/// - Creating log entries
	/// - Generating runtime metadata
	/// - Formatting log output
	/// - Routing logs to the Unity console
	/// - Handling log severity types
	/// </remarks>
	public static class MMLogger
	{
		#region Public Methods

		/// <summary>
		/// Creates and outputs a runtime log entry.
		/// </summary>
		/// <param name="category">Log category.</param>
		/// <param name="logType">Log severity type.</param>
		/// <param name="message">Log message content.</param>
		/// <param name="memberName">Caller method name.</param>
		/// <param name="filePath">Caller source file path.</param>
		/// <param name="lineNumber">Caller source line number.</param>
		public static void Log(
			MMLogCategory category,
			MMLogType logType,
			string message,
			[CallerMemberName] string memberName = "",
			[CallerFilePath] string filePath = "",
			[CallerLineNumber] int lineNumber = 0)
		{
			if (!MMLoggerSettings.Config.EnableLogging)
			{
				return;
			}

			MMLogMetadata metadata =
				CreateMetadata(
					memberName,
					filePath,
					lineNumber);

			MMLogEntry logEntry =
				new MMLogEntry
				{
					LogType = logType,
					LogCategory = category,
					Message = message,
					Metadata = metadata
				};

			PrintLog(logEntry);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Creates runtime metadata for a log entry.
		/// </summary>
		/// <param name="memberName">Caller method name.</param>
		/// <param name="filePath">Caller source file path.</param>
		/// <param name="lineNumber">Caller source line number.</param>
		/// <returns>Generated log metadata.</returns>
		private static MMLogMetadata CreateMetadata(
			string memberName,
			string filePath,
			int lineNumber)
		{
			string fileName =
				Path.GetFileName(filePath);

			string className =
				Path.GetFileNameWithoutExtension(filePath);

			return new MMLogMetadata
			{
				ClassName = className,
				MethodName = memberName,
				FileName = fileName,
				LineNumber = lineNumber,
				Timestamp = DateTime.Now
			};
		}

		/// <summary>
		/// Formats and outputs a log entry to the Unity console.
		/// </summary>
		/// <param name="logEntry">Target log entry.</param>
		private static void PrintLog(
			MMLogEntry logEntry)
		{
			string finalMessage =
				MMLogFormattingUtility.FormatLog(logEntry);

			switch (logEntry.LogType)
			{
				case MMLogType.Warning:

					Debug.LogWarning(finalMessage);
					break;

				case MMLogType.Error:
				case MMLogType.Exception:

					Debug.LogError(finalMessage);
					break;

				default:

					Debug.Log(finalMessage);
					break;
			}
		}

		#endregion
	}
}