using System;

namespace MayaMystic.Logger.Models
{
	/// <summary>
	/// Contains metadata information for logs.
	/// </summary>
	[Serializable]
	public class MMLogMetadata
	{
		#region Public Variables

		/// <summary>
		/// Class name where log originated.
		/// </summary>
		public string ClassName;

		/// <summary>
		/// Method name where log originated.
		/// </summary>
		public string MethodName;

		/// <summary>
		/// Source file name.
		/// </summary>
		public string FileName;

		/// <summary>
		/// Source line number.
		/// </summary>
		public int LineNumber;

		/// <summary>
		/// Log timestamp.
		/// </summary>
		public DateTime Timestamp;

		#endregion
	}
}