/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLogColorUtility.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Provides utility methods for runtime log color formatting
 *  using Unity rich text color tags.
 * 
 **************************************************************************/

using MayaMystic.Logger.Models;

namespace MayaMystic.Logger.Utilities
{
	/// <summary>
	/// Utility class for runtime log color formatting.
	/// </summary>
	/// <remarks>
	/// Responsible for:
	/// - Returning color values for log types
	/// - Applying Unity rich text color formatting
	/// - Supporting colored console log output
	/// </remarks>
	public static class MMLogColorUtility
	{
		#region Public Methods

		/// <summary>
		/// Returns the hexadecimal color value associated with a log type.
		/// </summary>
		/// <param name="logType">Target log type.</param>
		/// <returns>Hexadecimal color string.</returns>
		public static string GetColor(MMLogType logType)
		{
			switch (logType)
			{
				case MMLogType.Info:
					return "#FFFFFF";

				case MMLogType.Warning:
					return "#FFC107";

				case MMLogType.Error:
					return "#F44336";

				case MMLogType.Success:
					return "#4CAF50";

				case MMLogType.Debug:
					return "#03A9F4";

				case MMLogType.Network:
					return "#9C27B0";

				case MMLogType.Exception:
					return "#FF5722";

				default:
					return "#FFFFFF";
			}
		}

		/// <summary>
		/// Applies a Unity rich text color tag to the specified text.
		/// </summary>
		/// <param name="text">Target text content.</param>
		/// <param name="hexColor">Hexadecimal color value.</param>
		/// <returns>Formatted rich text string.</returns>
		public static string ApplyColor(
			string text,
			string hexColor)
		{
			return $"<color={hexColor}>{text}</color>";
		}

		#endregion
	}
}