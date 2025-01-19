using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	public class AVPlugins : IAVCorePlugins
	{
		private static readonly object instanceMutex;

		private static IAVCorePlugins instance;

		private readonly object mutex;

		private IHttpClient httpClient;

		private IAppRouterController appRouterController;

		private IAVCommandRunner commandRunner;

		private IStorageController storageController;

		private IAVCloudCodeController cloudCodeController;

		private IAVConfigController configController;

		private IAVFileController fileController;

		private IAVObjectController objectController;

		private IAVQueryController queryController;

		private IAVSessionController sessionController;

		private IAVUserController userController;

		private IObjectSubclassingController subclassingController;

		private IAVCurrentUserController currentUserController;

		private IInstallationIdController installationIdController;

		public static IAVCorePlugins Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IHttpClient HttpClient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAppRouterController AppRouterController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVCommandRunner CommandRunner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IStorageController StorageController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVCloudCodeController CloudCodeController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVFileController FileController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVConfigController ConfigController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVObjectController ObjectController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVQueryController QueryController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVSessionController SessionController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVUserController UserController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IAVCurrentUserController CurrentUserController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IObjectSubclassingController SubclassingController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IInstallationIdController InstallationIdController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Reset()
		{
		}
	}
}
