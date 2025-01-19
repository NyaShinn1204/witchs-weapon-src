using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantPreviewEvent
	{
		private static ServantPreviewEvent s_ServantPreviewEvent;

		public SingleServantInfo servantInfo;

		public Action OnDataChange;

		public void Bind(long svID)
		{
		}

		public void TryInvoke()
		{
		}

		public static ServantPreviewEvent GetInstance()
		{
			return null;
		}
	}
}
