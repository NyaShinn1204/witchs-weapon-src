using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SkillInBattleNew : UIPanelSingle
{
	private const int LIMIT_MAX_HEIGHT = 99;

	private const int LIMIT_OVER_HEIGHT = 50;

	private const float POWER_SCALE = 0.607f;

	private const string DURABILITY_DURABILITY = "Common_Weapon_Durability";

	private const string DURABILITY_BAR_DURABILITY_STOP = "Common_Weapon_Durability_Stop";

	public UIWidget servantDragger;

	public UISprite photo;

	public UISprite[] ranks;

	public UISprite rankColor;

	public UIWidget weapon;

	public UISprite weaponIcon;

	public UISprite weaponBg;

	public UISprite weaponTypeIcon;

	public UISprite changeWeaponCDIcon;

	public GameObject powerFullFlash;

	private string weaponTypeIconStrBase;

	public UISprite durabilityBar;

	public UISprite durabilityText;

	public UISprite weaponFailure;

	public GameObject durationEmpty;

	public GameObject durationEmptyFlash;

	public UISprite powerBar;

	public UISprite powerFlash;

	[SerializeField]
	private bool isHidePowerBar;

	public GameObject isHired;

	[SerializeField]
	private SkillInBattleDataNew skillData;

	private BuildPowerAndSharp stateInfo;

	private Vector3 cacheServantDraggerPos;

	private float cacheDuration;

	private bool isTrigger;

	[HideInInspector]
	public BattleSkillBtnState skillBtnState;

	public float ChangeWeaponCD
	{
		set
		{
		}
	}

	public int SkillIndex
	{
		get
		{
			return 0;
		}
	}

	public long WeaponId
	{
		get
		{
			return 0L;
		}
	}

	public long ServantId
	{
		get
		{
			return 0L;
		}
	}

	public BuildPowerAndSharp StateInfo
	{
		get
		{
			return null;
		}
	}

	public SkillInBattleDataNew SkillData
	{
		get
		{
			return null;
		}
	}

	protected override void Awake()
	{
	}

	public void Init(long servantId, int servantRank, long weaponId, int skillIndex)
	{
	}

	private void Update()
	{
	}

	private void OnDragStart(GameObject go)
	{
	}

	private void OnDragEvent(GameObject go, Vector2 delta)
	{
	}

	private void OnDragEndEvent(GameObject go)
	{
	}

	public void SetMode(SkillInBattleDataNew.WeaponModes mode)
	{
	}

	public void OnClick(GameObject go)
	{
	}

	private void Try2ConsumeInitFullEnergy()
	{
	}
}
