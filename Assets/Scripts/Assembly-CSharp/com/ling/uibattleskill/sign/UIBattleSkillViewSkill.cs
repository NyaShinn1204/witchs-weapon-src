using UnityEngine;
using WaterBell.ProjX.Level;

namespace com.ling.uibattleskill.sign
{
	public class UIBattleSkillViewSkill
	{
		public enum UIBattleSkillBtnType
		{
			isNull = 0,
			isUnableRelease = 1,
			isUnableWeapon = 2,
			isHide = 4
		}

		private uint _state;

		private GameObject _viewSkill;

		private GameObject _viewDurability;

		private BattlePlayerSettingManager.SvUIInfo _info;

		private UISprite _iconWeapon;

		private UISprite _iconWeaponFailure;

		private UISprite _iconServant;

		private UISprite _iconRankColor;

		private UISprite _scrollPower;

		private GameObject _viewEffectPowerFull;

		private GameObject _iconHired;

		private UISprite _scrollDuration;

		private GameObject _viewEffectDurationEmpty;

		private UISprite _iconWeaponType;

		private UISprite _iconWeaponTypeCD;

		private UILabel _labelWeaponTypeCD;

		private Transform _viewDurabilityLock;

		private UISprite _viewDurabilityLockScroll;

		private Transform _viewLockWeapon;

		private UISprite _viewLockWeaponCDView;

		private UILabel _viewLockWeaponCDLabel;

		public uint state
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool isBattleSkillUnableReleaseType
		{
			get
			{
				return false;
			}
		}

		public bool isBattleSkillUnableWeaponType
		{
			get
			{
				return false;
			}
		}

		public bool isBattleSkillHideType
		{
			get
			{
				return false;
			}
		}

		public bool isLockWeapon
		{
			get
			{
				return false;
			}
		}

		public float lockWeaponTimeTotal
		{
			get
			{
				return 0f;
			}
		}

		public float lockWeaponTimeCurrent
		{
			get
			{
				return 0f;
			}
		}

		public GameObject viewSkill
		{
			get
			{
				return null;
			}
		}

		public GameObject viewDurability
		{
			get
			{
				return null;
			}
		}

		public BattlePlayerSettingManager.SvUIInfo info
		{
			get
			{
				return default(BattlePlayerSettingManager.SvUIInfo);
			}
		}

		public UISprite iconWeapon
		{
			get
			{
				return null;
			}
		}

		public UISprite iconWeaponFailure
		{
			get
			{
				return null;
			}
		}

		public UISprite iconServant
		{
			get
			{
				return null;
			}
		}

		public TypeCsvServantWeapon csvServantWeapon
		{
			get
			{
				return null;
			}
		}

		public TypeCsvServant csvServant
		{
			get
			{
				return null;
			}
		}

		public TypeCsvServantClient csvServantClient
		{
			get
			{
				return null;
			}
		}

		public TypeCsvSpell csvSpell
		{
			get
			{
				return null;
			}
		}

		public SkillTPL skillTPL
		{
			get
			{
				return null;
			}
		}

		public long idServant
		{
			get
			{
				return 0L;
			}
		}

		public UIBattleSkillViewSkill(GameObject sViewSkill, GameObject sViewDurability, BattlePlayerSettingManager.SvUIInfo sInfo)
		{
		}

		public void initView()
		{
		}

		public void changeWeapon(UIBattleSkillViewSkill sPre, bool sIsChangeWeapon = true)
		{
		}

		public void eventView()
		{
		}

		private void drawWeaponLock()
		{
		}
	}
}
