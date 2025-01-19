using System.Runtime.InteropServices;

namespace WaterBell.ProjX.View.Panel
{
	public class UILootItemSpriteEx : UIResSpriteEx
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void BtnClickDelegate(long _id);

		private UILootItemData itemData;

		public BtnClickDelegate action;

		protected override void Awake()
		{
		}

		protected override void OnClickAction()
		{
		}

		protected override void InitConfig()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
