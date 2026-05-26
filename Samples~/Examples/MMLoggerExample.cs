using MayaMystic.Logger.Core;
using MayaMystic.Logger.Models;
using UnityEngine;

namespace MayaMystic.Logger.Example
{
	/// <summary>
	/// Example usage for MayaMystic Logger.
	/// </summary>
	public class MMLoggerExample : MonoBehaviour
	{
		#region Unity Methods

		private void Start()
		{
			//RunAllTests();
		}

		#endregion

		#region Test Runner

		/// <summary>
		/// Runs all logger tests.
		/// </summary>
		[ContextMenu("Run All Logger Tests")]
		public void RunAllTests()
		{
			TestInfoLog();

			TestWarningLog();

			TestErrorLog();

			TestSuccessLog();

			TestDebugLog();

			TestNetworkLog();

			TestExceptionLog();
		}

		#endregion

		#region Info Test

		/// <summary>
		/// Tests info log.
		/// </summary>
		[ContextMenu("Test/Info Log")]
		public void TestInfoLog()
		{
			MMLogger.Log(MMLogCategory.Core,MMLogType.Info,"This is an info log.");
		}

		#endregion

		#region Warning Test

		/// <summary>
		/// Tests warning log.
		/// </summary>
		[ContextMenu("Test/Warning Log")]
		public void TestWarningLog()
		{
			MMLogger.Log(MMLogCategory.FileManager,MMLogType.Warning,"This is a warning log.");
		}

		#endregion

		#region Error Test

		/// <summary>
		/// Tests error log.
		/// </summary>
		[ContextMenu("Test/Error Log")]
		public void TestErrorLog()
		{
			MMLogger.Log(MMLogCategory.DownloadFramework,MMLogType.Error,"This is an error log.");
		}

		#endregion

		#region Success Test

		/// <summary>
		/// Tests success log.
		/// </summary>
		[ContextMenu("Test/Success Log")]
		public void TestSuccessLog()
		{
			MMLogger.Log(MMLogCategory.API,MMLogType.Success,"Operation completed successfully.");
		}

		#endregion

		#region Debug Test

		/// <summary>
		/// Tests debug log.
		/// </summary>
		[ContextMenu("Test/Debug Log")]
		public void TestDebugLog()
		{
			MMLogger.Log(MMLogCategory.UI,MMLogType.Debug,"This is a debug log.");
		}

		#endregion

		#region Network Test

		/// <summary>
		/// Tests network log.
		/// </summary>
		[ContextMenu("Test/Network Log")]
		public void TestNetworkLog()
		{
			MMLogger.Log(MMLogCategory.Network,MMLogType.Network,"Network request completed.");
		}

		#endregion

		#region Exception Test

		/// <summary>
		/// Tests exception log.
		/// </summary>
		[ContextMenu("Test/Exception Log")]
		public void TestExceptionLog()
		{
			try
			{
				int value = 0;

				int result = 10 / value;

				MMLogger.Log(MMLogCategory.Core,MMLogType.Info,"Result: " + result);
			}
			catch (System.Exception exception)
			{
				MMLogger.Log(
					MMLogCategory.Core,MMLogType.Exception,$"Exception occurred: {exception.Message}");
			}
		}

		#endregion
	}
}