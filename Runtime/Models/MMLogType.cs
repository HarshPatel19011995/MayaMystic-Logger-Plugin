namespace MayaMystic.Logger.Models
{
	/// <summary>
	/// Represents supported log severity types within the MayaMystic Logger framework.
	/// </summary>
	public enum MMLogType
	{
		/// <summary>
		/// Informational log message.
		/// </summary>
		Info,

		/// <summary>
		/// Warning log message.
		/// </summary>
		Warning,

		/// <summary>
		/// Error log message.
		/// </summary>
		Error,

		/// <summary>
		/// Success log message.
		/// </summary>
		Success,

		/// <summary>
		/// Debug log message.
		/// </summary>
		Debug,

		/// <summary>
		/// Network-related log message.
		/// </summary>
		Network,

		/// <summary>
		/// Exception log message.
		/// </summary>
		Exception
	}
}