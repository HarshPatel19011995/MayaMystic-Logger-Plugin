/**************************************************************************
 * 
 *  Project     : MayaMystic Logger Framework
 *  File        : MMLoggerSettings.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Provides global access to the MayaMystic Logger
 *  configuration system.
 *  Handles loading and caching of logger configuration assets.
 * 
 **************************************************************************/

using MayaMystic.Logger.Config;
using MayaMystic.Logger.Constants;
using UnityEngine;

namespace MayaMystic.Logger.Core
{
	/// <summary>
	/// Provides global access to the MayaMystic Logger configuration asset.
	/// </summary>
	/// <remarks>
	/// Responsible for loading and caching the
	/// <see cref="MMLoggerConfig"/> instance from the Unity Resources folder.
	/// </remarks>
	public static class MMLoggerSettings
	{
		#region Private Variables

		/// <summary>
		/// Cached instance of the loaded logger configuration.
		/// </summary>
		private static MMLoggerConfig cachedConfig;

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets the loaded logger configuration instance.
		/// </summary>
		/// <remarks>
		/// Automatically loads the configuration asset
		/// if it has not already been loaded.
		/// </remarks>
		public static MMLoggerConfig Config
		{
			get
			{
				if (cachedConfig == null)
				{
					LoadConfig();
				}

				return cachedConfig;
			}
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Loads the logger configuration asset from the Resources folder.
		/// </summary>
		private static void LoadConfig()
		{
			cachedConfig =
				Resources.Load<MMLoggerConfig>(
					MMLoggerConstants.CONFIG_RESOURCE_PATH);

			if (cachedConfig == null)
			{
				Debug.LogError(
					$"{MMLoggerConstants.LOG_PREFIX} Failed to load MMLoggerConfig asset from Resources folder.");
			}
			else
			{
				Debug.Log(
					$"{MMLoggerConstants.LOG_PREFIX} MMLoggerConfig loaded successfully from Resources.");
			}
		}

		#endregion
	}
}