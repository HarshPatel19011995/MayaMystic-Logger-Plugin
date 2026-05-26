namespace MayaMystic.Logger.Models
{
	/// <summary>
	/// Represents supported log categories within the MayaMystic Logger framework.
	/// </summary>
	public enum MMLogCategory
	{
		/// <summary>
		/// Core framework systems.
		/// </summary>
		Core,

		/// <summary>
		/// FileManager framework operations.
		/// </summary>
		FileManager,

		/// <summary>
		/// Download framework operations.
		/// </summary>
		DownloadFramework,

		/// <summary>
		/// API and web request systems.
		/// </summary>
		API,

		/// <summary>
		/// User interface systems.
		/// </summary>
		UI,

		/// <summary>
		/// Localization and language systems.
		/// </summary>
		Localization,

		/// <summary>
		/// Save system operations.
		/// </summary>
		SaveSystem,

		/// <summary>
		/// Network-related operations.
		/// </summary>
		Network,

		/// <summary>
		/// Cache system operations.
		/// </summary>
		Cache,

		/// <summary>
		/// Authentication and login systems.
		/// </summary>
		Authentication
	}
}