using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonProps : UIPanelSingle
	{
		private static MainUIRoot root;

		private static UserServantManagerViewModel usmVM;

		private static Package pkgCoreMen;

		public Article article;

		public UILabel addExpLabel;

		public UIButtonLongPressTick tickComp;

		protected CommonPropsData pData;

		private int tickSum;

		private int origLv;

		private long origExp;

		private int eachItemExpVavlue;

		private string refreshMsg;

		protected override void Start()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void onTickDone()
		{
		}

		private long GetServantExpLimit(long servantLv)
		{
			return 0L;
		}
	}
}
