using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using com.ling.uibattleskill.sign;

public class UIBattleSkill : GUtilUISuper
{
	public class UIBattleSkillReleaseData
	{
		public Vector3 position;

		public Entity target;

		public UIBattleSkillReleaseData(Vector3 sPosition, Entity sTarget)
		{
		}
	}

	private class UIBattleSkillViewDurabilityRound
	{
		private GameObject _view;

		private List<UIWidget> _viewDurabilitySelectRoundList;

		private FunctionUIBattleSkillViewSkillJoystick _listenerWeaponHD;

		private int _touchID;

		private bool _isShow;

		private Vector3 InputMousePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		private bool InputMouseRelease
		{
			get
			{
				return false;
			}
		}

		public UIBattleSkillViewDurabilityRound(GameObject sView, GameObject sViewCancel, List<UIWidget> sViewDurabilitySelectRoundList, FunctionUIBattleSkillViewSkillJoystick sListenerWeaponHD)
		{
		}

		public void show()
		{
		}

		public void hide()
		{
		}

		public void eventView(List<UIBattleSkillViewSkill> sListSkill)
		{
		}

		private UIBattleSkillViewSkill GetCurrentWeapon(List<UIBattleSkillViewSkill> sListSkill)
		{
			return null;
		}

		public void MoveToWeaponAnim(UIBattleSkillViewSkill sViewSkill, bool sIsTween = true)
		{
		}
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionUIBattleSkillViewSkillJoystick(UIBattleSkillViewSkill sData);

	public static Dictionary<long, UIBattleSkillReleaseData> _releaseData;

	private static float _CDWeapon;

	public static bool RESET_FOR_PAUSE;

	private UIBattleSkillViewSkill _skillCurrent;

	private GameObject _weaponViewSelect;

	private List<UIBattleSkillViewSkill> _skill;

	private UIBattleSkillViewSkillJoystick _skillJoystick;

	private UIBattleSkillViewDurabilityRound _skillDurabilityRound;

	private List<UIWidget> _durabilitySelectRoundList;

	private Vector3 _initViewSkillPostion;

	private Vector3 _initViewDurabilityPostion;

	private int _pauseNext;

	private List<GameObject> _btnAtkMouseDownEffect;

	private float _eventWeaponChangeHelpTime;

	private bool _eventWeaponChangeHelpIsShow;

	private List<GameObject> _eventWeaponChangeHelpView;

	public static float CDWeaponTotal
	{
		get
		{
			return 0f;
		}
	}

	public static float CDWeapon
	{
		get
		{
			return 0f;
		}
	}

	public static UIBattleSkillReleaseData getReleaseData(long sID)
	{
		return null;
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	private void Update()
	{
	}

	private void btnSkillMouseDown(string[] sArg)
	{
	}

	private void btnDurability(string[] sArg)
	{
	}

	private void btnDurabilityRoundMouseDown()
	{
	}

	private void btnAtkMouseDown()
	{
	}

	private void btnAtkMouseDownEffectHD()
	{
	}

	private void skillJoystickReleaseHD(UIBattleSkillViewSkill sData)
	{
	}

	private void skillJoystickWeaponHD(UIBattleSkillViewSkill sData)
	{
	}

	public void resetWeapon(string sIndex = "0")
	{
	}

	public void clearReleaseData()
	{
	}

	public void hide()
	{
	}

	public void show()
	{
	}

	public void SetSkillBtnType(int sIndex, UIBattleSkillViewSkill.UIBattleSkillBtnType sState)
	{
	}

	private void ReDrawButtonSkill()
	{
	}

	private void eventWeaponChangeHelp()
	{
	}

	public void SetEventWeaponChangeHelpIsShow(bool sIsShow)
	{
	}

	public Vector3 OffsetVextor3SkillChangeWeapon(int sIndex)
	{
		return default(Vector3);
	}
}
