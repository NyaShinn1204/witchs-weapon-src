namespace WaterBell.ProjX.View.Panel
{
	public class WDP_Awake : UIPanelSingle
	{
		public WeaponItem coreItem;

		public WeaponItem item1;

		public WeaponItem item2;

		public UILabel needGoldLabel;

		public UISprite needRankIcon;

		public UILabel needRankIconLabel;

		public ButtonEx awakeButton;

		public UITexture awakeIcon;

		public UITexture unawakeIcon;

		public LoadUIPanelSingle successfulLoader;

		public LoadUIPanelSingle confirmLoader;

		public ButtonEx helpButton;

		public UISprite weaponRareIcon;

		public UISprite weaponTypeIcon;

		public UILabel weaponNameLabel;

		public UtilAnchorAnim animAnchor;

		private SingleWeaponInfo weaponInfo;

		private CurrentServantWeaponPromoteSpellView view;

		private bool showAwakeEffect;

		private float timeLock;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		private void OpenHelpPanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void AwakeButtonClick()
		{
		}

		private void Update()
		{
		}

		private void ShowAwakeSuccPanel()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
