using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantArchivePanel : UIPanelSingle
	{
		public UILabel weapon_nameLabel;

		public UISprite weapon_rare;

		public UISprite weapon_type;

		public WDP_SkillIcon weapon_skillButton1;

		public WDP_SkillIcon weapon_skillButton2;

		public UIWeaponSpellTipController weapon_spellTip;

		public UILabel witch_nameLabel;

		public GameObject witch_spell1;

		public GameObject witch_spell2;

		public UIWitchSpellTipController witch_spellTip;

		public UtilAnchorAnim weapon_Anim;

		public UtilAnchorAnim witch_Anim;

		public UIPanelSingleContainer witch_imageContainer;

		public UIMixWidget weapon_image;

		public ButtonEx spellButton;

		public ButtonEx weaponSpellButton;

		private UIPanelSingle currentOpen;

		private string currentTag;

		private static ServantArchivePanel s_Current;

		private long witch_Spell1ID
		{
			get
			{
				return 0L;
			}
		}

		private long witch_Spell2ID
		{
			get
			{
				return 0L;
			}
		}

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		public static ServantArchivePanel GetInstance()
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		protected override void BindData()
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		private void OpenChild(string child)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void ShowSpellTip(int sIndex)
		{
		}
	}
}
