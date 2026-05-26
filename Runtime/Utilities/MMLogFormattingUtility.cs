/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLogFormattingUtility.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Provides utility methods for formatting runtime log entries
 *  into structured and colorized console output.
 * 
 **************************************************************************/

using MayaMystic.Logger.Constants;
using MayaMystic.Logger.Core;
using MayaMystic.Logger.Models;

namespace MayaMystic.Logger.Utilities
{
	/// <summary>
	/// Utility class responsible for formatting runtime log entries.
	/// </summary>
	/// <remarks>
	/// Handles:
	/// - Structured log formatting
	/// - Runtime metadata display
	/// - Icon generation
	/// - Timestamp formatting
	/// - Rich text color formatting
	/// </remarks>
	public static class MMLogFormattingUtility
	{
		#region Public Methods

		/// <summary>
		/// Formats a log entry into the final display string.
		/// </summary>
		/// <param name="logEntry">Target log entry.</param>
		/// <returns>Formatted runtime log string.</returns>
		public static string FormatLog(
			MMLogEntry logEntry)
		{
			string icon =
				GetIcon(logEntry.LogType);

			string color =
				MMLogColorUtility.GetColor(logEntry.LogType);

			string formattedMessage =
				$"{icon} ";

			if (MMLoggerSettings.Config.ShowTimestamp)
			{
				formattedMessage +=
					$"[{logEntry.Metadata.Timestamp.ToString(MMLoggerConstants.TIMESTAMP_FORMAT)}] ";
			}

			if (MMLoggerSettings.Config.ShowLogType)
			{
				formattedMessage +=
					$"[{logEntry.LogType}] ";
			}

			if (MMLoggerSettings.Config.ShowCategory)
			{
				formattedMessage +=
					$"[{logEntry.LogCategory}] ";
			}

			if (MMLoggerSettings.Config.ShowMethodName)
			{
				formattedMessage +=
					$"[{logEntry.Metadata.MethodName}] ";
			}

			if (MMLoggerSettings.Config.ShowFileName)
			{
				formattedMessage +=
					$"[{logEntry.Metadata.FileName}] ";
			}

			formattedMessage +=
				$"{logEntry.Message}";

			return MMLogColorUtility.ApplyColor(
				formattedMessage,
				color);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Returns the icon associated with the specified log type.
		/// </summary>
		/// <param name="logType">Target log type.</param>
		/// <returns>Log icon string.</returns>
		private static string GetIcon(
			MMLogType logType)
		{
			switch (logType)
			{
				case MMLogType.Info:
					return MMLoggerConstants.INFO_ICON;

				case MMLogType.Warning:
					return MMLoggerConstants.WARNING_ICON;

				case MMLogType.Error:
					return MMLoggerConstants.ERROR_ICON;

				case MMLogType.Success:
					return MMLoggerConstants.SUCCESS_ICON;

				case MMLogType.Debug:
					return MMLoggerConstants.DEBUG_ICON;

				case MMLogType.Network:
					return MMLoggerConstants.NETWORK_ICON;

				case MMLogType.Exception:
					return MMLoggerConstants.EXCEPTION_ICON;

				default:
					return MMLoggerConstants.INFO_ICON;
			}
		}

		#endregion
	}
}