namespace LeanCloud.Realtime.Internal
{
	internal class AVIMCorePlugins
	{
		private static readonly AVIMCorePlugins instance;

		private readonly object mutex;

		private IAVRouterController routerController;

		private IFreeStyleMessageClassingController freeStyleClassingController;

		public static AVIMCorePlugins Instance
		{
			get
			{
				return null;
			}
		}

		public IAVRouterController RouterController
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public IFreeStyleMessageClassingController FreeStyleClassingController
		{
			get
			{
				return null;
			}
		}
	}
}
