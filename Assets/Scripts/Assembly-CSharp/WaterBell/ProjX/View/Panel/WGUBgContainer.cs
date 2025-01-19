namespace WaterBell.ProjX.View.Panel
{
	public class WGUBgContainer : UIPanelSingle
	{
		public WGUBgColor bgColor;

		public WGUBgBoxContainer bgBoxContainer;

		public TweenAlpha bgLightTweenAlpha;

		public UIPanelSingleContainer watchmenPhotoContainer;

		public ServantGiftCloth servantGiftCloth;

		private TypeCsvServant servantTableData;

		private long servantCardID;

		private string childName;

		public TweenPosition tweenPosition;

		public static WGUBgContainer current;

		protected override void Awake()
		{
		}

		public void OpenChild(string childName)
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
