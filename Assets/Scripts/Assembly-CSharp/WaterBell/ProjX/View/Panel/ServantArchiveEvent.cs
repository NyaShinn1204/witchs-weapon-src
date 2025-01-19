using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantArchiveEvent
	{
		private static ServantArchiveEvent s_ServantPreviewEvent;

		public SingleServantInfo servantInfo;

		public Action OnDataChange;

		public float patk;

		public float matk;

		public void Bind(long svID)
		{
		}

		public void TryInvoke()
		{
		}

		public static ServantArchiveEvent GetInstance()
		{
			return null;
		}
	}
}
