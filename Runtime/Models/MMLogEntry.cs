using System;

namespace MayaMystic.Logger.Models
{
	/// <summary>
	/// Represents a structured runtime log entry.
	/// </summary>
	/// <remarks>
	/// Stores the complete log information including:
	/// log type, category, message content,
	/// and runtime metadata.
	/// </remarks>
	[Serializable]
	public class MMLogEntry
	{
		#region Public Variables

		/// <summary>
		/// Type or severity level of the log entry.
		/// </summary>
		public MMLogType LogType;

		/// <summary>
		/// Category associated with the log entry.
		/// </summary>
		public MMLogCategory LogCategory;

		/// <summary>
		/// Main log message content.
		/// </summary>
		public string Message;

		/// <summary>
		/// Runtime metadata associated with the log entry.
		/// </summary>
		public MMLogMetadata Metadata;

		#endregion
	}
}