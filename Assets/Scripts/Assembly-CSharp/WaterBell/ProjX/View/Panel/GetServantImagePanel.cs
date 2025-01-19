using System;

namespace WaterBell.ProjX.View.Panel
{
	public class GetServantImagePanel : UIPanelSingle
	{
		private const string PREFAB_PATH = "UI/Prefab/GetServantImagePanel";

		private static GetServantImagePanel current;

		public ServantGiftCloth servantGiftCloth;

		public ButtonEx closeButton;

		public UILabel nameLabel;

		public UILabel descLabel;

		public long testID;

		public int testValue;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static GetServantImagePanel GetInstance()
		{
			return null;
		}

		public static bool IsPlayAnim(LotteryLootData lootData)
		{
			return false;
		}

		public void OpenPanel(LotteryLootData loot, Action onCloseEvent)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
