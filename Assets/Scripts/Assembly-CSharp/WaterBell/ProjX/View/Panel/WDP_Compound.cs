namespace WaterBell.ProjX.View.Panel
{
	public class WDP_Compound : UIPanelSingle
	{
		public WeaponItem coreItem;

		public WeaponItem item1;

		public WeaponItem item2;

		public ButtonEx compoundButton;

		public ButtonEx helpButton;

		protected SingleWeaponInfo weaponInfo;

		protected SingleServantInfo servantInfo;

		protected CompoundView view;

		public UISprite weaponRareIcon;

		public UISprite weaponTypeIcon;

		public UILabel weaponNameLabel;

		public UtilAnchorAnim animAnchor;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		protected override void BindData()
		{
		}

		public override void UpdatePanel()
		{
		}

		protected virtual void Compound()
		{
		}

		protected virtual void CloseGetWeaponAnim()
		{
		}

		private void OpenHelpPanel()
		{
		}
	}
}
