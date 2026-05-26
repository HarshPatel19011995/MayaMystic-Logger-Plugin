/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLoggerConfig.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Global configuration asset for the MayaMystic Logger framework.
 *  Controls runtime logging behavior, formatting,
 *  display settings, and stack trace handling.
 * 
 **************************************************************************/

using UnityEngine;

namespace MayaMystic.Logger.Config
{
	/// <summary>
	/// Global configuration settings for the MayaMystic Logger framework.
	/// </summary>
	/// <remarks>
	/// This configuration asset controls runtime logging behavior including:
	/// log visibility, formatting options, stack traces,
	/// category display, and verbose logging settings.
	/// </remarks>
	[CreateAssetMenu(
		fileName = "MMLoggerConfig",
		menuName = "MayaMystic/Logger/MMLoggerConfig",
		order = 0)]
	public class MMLoggerConfig : ScriptableObject
	{
		#region General Settings

		[Header("General Settings")]

		[SerializeField]
		[Tooltip("Determines whether runtime logging is enabled.")]
		private bool enableLogging = true;

		[SerializeField]
		[Tooltip("Determines whether verbose debug logging is enabled.")]
		private bool enableVerboseLogging = true;

		#endregion

		#region Display Settings

		[Header("Display Settings")]

		[SerializeField]
		[Tooltip("Determines whether timestamps are displayed in logs.")]
		private bool showTimestamp = true;

		[SerializeField]
		[Tooltip("Determines whether log types are displayed.")]
		private bool showLogType = true;

		[SerializeField]
		[Tooltip("Determines whether log categories are displayed.")]
		private bool showCategory = true;

		[SerializeField]
		[Tooltip("Determines whether class names are displayed.")]
		private bool showClassName = true;

		[SerializeField]
		[Tooltip("Determines whether method names are displayed.")]
		private bool showMethodName = true;

		[SerializeField]
		[Tooltip("Determines whether file names are displayed.")]
		private bool showFileName = false;

		#endregion

		#region Stack Trace Settings

		[Header("Stack Trace Settings")]

		[SerializeField]
		[Tooltip("Determines whether stack traces are enabled for error logs.")]
		private bool enableStackTraceForErrors = true;

		[SerializeField]
		[Tooltip("Determines whether stack traces are enabled for warning logs.")]
		private bool enableStackTraceForWarnings = false;

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets whether runtime logging is enabled.
		/// </summary>
		public bool EnableLogging =>
			enableLogging;

		/// <summary>
		/// Gets whether verbose debug logging is enabled.
		/// </summary>
		public bool EnableVerboseLogging =>
			enableVerboseLogging;

		/// <summary>
		/// Gets whether timestamps are displayed in logs.
		/// </summary>
		public bool ShowTimestamp =>
			showTimestamp;

		/// <summary>
		/// Gets whether log types are displayed in logs.
		/// </summary>
		public bool ShowLogType =>
			showLogType;

		/// <summary>
		/// Gets whether log categories are displayed in logs.
		/// </summary>
		public bool ShowCategory =>
			showCategory;

		/// <summary>
		/// Gets whether class names are displayed in logs.
		/// </summary>
		public bool ShowClassName =>
			showClassName;

		/// <summary>
		/// Gets whether method names are displayed in logs.
		/// </summary>
		public bool ShowMethodName =>
			showMethodName;

		/// <summary>
		/// Gets whether source file names are displayed in logs.
		/// </summary>
		public bool ShowFileName =>
			showFileName;

		/// <summary>
		/// Gets whether stack traces are enabled for error logs.
		/// </summary>
		public bool EnableStackTraceForErrors =>
			enableStackTraceForErrors;

		/// <summary>
		/// Gets whether stack traces are enabled for warning logs.
		/// </summary>
		public bool EnableStackTraceForWarnings =>
			enableStackTraceForWarnings;

		#endregion
	}
}