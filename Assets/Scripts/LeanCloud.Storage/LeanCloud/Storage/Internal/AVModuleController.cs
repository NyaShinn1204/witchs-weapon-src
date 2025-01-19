using System.Collections.Generic;

namespace LeanCloud.Storage.Internal
{
	public class AVModuleController
	{
		private static readonly AVModuleController instance;

		private readonly object mutex;

		private readonly List<IAVModule> modules;

		private bool isParseInitialized;

		public static AVModuleController Instance
		{
			get
			{
				return null;
			}
		}

		public void RegisterModule(IAVModule module)
		{
		}

		public void ScanForModules()
		{
		}

		public void Reset()
		{
		}

		public void LeanCloudDidInitialize()
		{
		}
	}
}
