using System.Collections.Generic;
using UnityEngine;

public class MngrData
{
	public enum AutoCombat
	{
		None = 0,
		SemiAutomatic = 1,
		Automatic = 2
	}

	public enum UIBattleSkillTypeEnum
	{
		Line = 0,
		Round = 1,
		Line2 = 2
	}

	public enum QualityTypeEnum
	{
		Fastest = 0,
		Mid = 2,
		Good = 3
	}

	public class MngrDataValue
	{
		public bool lockFlash;

		private GameObject _view;

		public string animLabel;

		private float _speedAnim;

		private float _speedMoveRate;

		public float _speedMove;

		public bool _speedPause;

		private bool _animPause;

		private float _still;

		private float _stillReset;

		public float speedAnimReal
		{
			get
			{
				return 0f;
			}
		}

		public float speedAnim
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float speedMoveRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float speedMoveReal
		{
			get
			{
				return 0f;
			}
		}

		public float speedMove
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool speedPause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool animPause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float still
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float stillReset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MngrDataValue(GameObject sView)
		{
		}

		public void Update()
		{
		}
	}

	private static AutoCombat _autoCombat;

	private static bool _IsSkillAnimShow;

	private static bool _IsLockJoyStick;

	private static UIBattleSkillTypeEnum _UIBattleSkillType;

	private const string _PREFS__UI_BATTLESKILL_TYPE = "com.ling.skill.ui.uibattleskill.type.";

	private static QualityTypeEnum _UIQuality;

	private static int _UIQualityVSyncCount;

	private static string _PREFS_QUALITY;

	private static string _PREFS_QUALITY_V_SYNC_COUNT;

	private static MngrData _instance;

	private static float _speedPublic;

	private static string _speedPublicHDString;

	private static Dictionary<GameObject, MngrDataValue> _data;

	private static string _PREFS_AUTO_COMBAT
	{
		get
		{
			return null;
		}
	}

	public static AutoCombat AutoCombatMode
	{
		get
		{
			return default(AutoCombat);
		}
		set
		{
		}
	}

	public static bool isMemoryUnloadOnClose
	{
		get
		{
			return false;
		}
	}

	private static string _PREFS_IS_Skill_ANIM_SHOW
	{
		get
		{
			return null;
		}
	}

	public static bool IsSkillAnimShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static string _PREFS_IS_LOCK_JOYSTICK
	{
		get
		{
			return null;
		}
	}

	public static bool IsLockJoyStick
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static UIBattleSkillTypeEnum UIBattleSkillType
	{
		get
		{
			return default(UIBattleSkillTypeEnum);
		}
		set
		{
		}
	}

	public static QualityTypeEnum Quality
	{
		get
		{
			return default(QualityTypeEnum);
		}
		set
		{
		}
	}

	public static int QualityVSyncCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static MngrData instance
	{
		get
		{
			return null;
		}
	}

	public MngrDataValue Item
	{
		get
		{
			return null;
		}
	}

	public static void slowAllEntity(float sTime, float sSpeed = 0.3f)
	{
	}

	private static void slowAllEntityReset()
	{
	}

	public void clear()
	{
	}
}
