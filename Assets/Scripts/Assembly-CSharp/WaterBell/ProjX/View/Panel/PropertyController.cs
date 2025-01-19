using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class PropertyController : UIPanelSingle
	{
		public UILabel foundation_1;

		public UILabel foundation_2;

		public UILabel foundation_3;

		public UILabel foundation_4;

		public UILabel energy_1;

		public UILabel energy_2;

		public UILabel energy_3;

		public UILabel energy_4;

		public UILabel physics_1;

		public UILabel physics_2;

		public UILabel physics_3;

		public UILabel physics_4;

		public UILabel physics_5;

		public UILabel magic_1;

		public UILabel magic_2;

		public UILabel magic_3;

		public UILabel magic_4;

		public UILabel magic_5;

		public GameObject prop;

		public SingleServantPropertyView user;

		public static PropertyController current;

		private SingleWeaponInfo weaponInfo;

		private SingleServantInfo servantInfo;

		public ButtonEx closeBtn;

		public UISlider slider;

		public PropertyRadar radar;

		public UILabel svStyle;

		public UtilAnchorAnim anim;

		public UILabel servantName;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void OpenPropPanel()
		{
		}

		public void OpenCvPanel()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void ShowProperty(ServantPropertyInfo data)
		{
		}
	}
}
