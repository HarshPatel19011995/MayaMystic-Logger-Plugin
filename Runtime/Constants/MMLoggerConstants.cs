/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLoggerConstants.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Contains global constants used throughout the
 *  MayaMystic Logger framework.
 * 
 **************************************************************************/

namespace MayaMystic.Logger.Constants
{
	/// <summary>
	/// Contains global constants for the MayaMystic Logger framework.
	/// </summary>
	public static class MMLoggerConstants
	{
		#region Resource Paths

		/// <summary>
		/// Resource path used to load the logger configuration asset.
		/// </summary>
		public const string CONFIG_RESOURCE_PATH =
			"MMLoggerConfig";

		#endregion

		#region Log Prefix

		/// <summary>
		/// Global prefix used for logger-related messages.
		/// </summary>
		public const string LOG_PREFIX =
			"[MayaMystic.Logger]";

		#endregion

		#region Log Icons

		/// <summary>
		/// Icon used for informational logs.
		/// </summary>
		public const string INFO_ICON =
			"ℹ️";

		/// <summary>
		/// Icon used for warning logs.
		/// </summary>
		public const string WARNING_ICON =
			"⚠️";

		/// <summary>
		/// Icon used for error logs.
		/// </summary>
		public const string ERROR_ICON =
			"❌";

		/// <summary>
		/// Icon used for success logs.
		/// </summary>
		public const string SUCCESS_ICON =
			"✅";

		/// <summary>
		/// Icon used for debug logs.
		/// </summary>
		public const string DEBUG_ICON =
			"🛠️";

		/// <summary>
		/// Icon used for network-related logs.
		/// </summary>
		public const string NETWORK_ICON =
			"🌐";

		/// <summary>
		/// Icon used for exception logs.
		/// </summary>
		public const string EXCEPTION_ICON =
			"💥";

		#endregion

		#region Formatting

		/// <summary>
		/// Default timestamp format used in logger output.
		/// </summary>
		public const string TIMESTAMP_FORMAT =
			"HH:mm:ss";

		#endregion
	}
}