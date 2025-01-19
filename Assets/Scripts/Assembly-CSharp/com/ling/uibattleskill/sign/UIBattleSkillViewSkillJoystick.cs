using UnityEngine;

namespace com.ling.uibattleskill.sign
{
	public class UIBattleSkillViewSkillJoystick
	{
		private UIBattleSkillViewArea _area;

		private UIBattleSkill.FunctionUIBattleSkillViewSkillJoystick _listenerReleaseHD;

		private UIBattleSkill.FunctionUIBattleSkillViewSkillJoystick _listenerWeaponHD;

		private bool _isActive;

		private Vector3 _activePosition;

		private UIBattleSkillViewSkill _skill;

		private GameObject _view;

		private GameObject _point;

		private GameObject _viewCancel;

		private float _time;

		private float _moveDistance;

		private float _moveDistanceWhileSelect;

		private Vector3 _moveDistancePre;

		private int _touchID;

		public UIBattleSkillViewSkill skill
		{
			get
			{
				return null;
			}
		}

		public Vector3 dirXZ
		{
			get
			{
				return default(Vector3);
			}
		}

		public float lenMul
		{
			get
			{
				return 0f;
			}
		}

		private bool InputMoveWhileSelect
		{
			get
			{
				return false;
			}
		}

		private bool IsPowerFull
		{
			get
			{
				return false;
			}
		}

		private bool InputIsSelect
		{
			get
			{
				return false;
			}
		}

		private bool InputMouseOnCancel
		{
			get
			{
				return false;
			}
		}

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

		public UIBattleSkillViewSkillJoystick(GameObject sView, GameObject sViewCancel, UIBattleSkill.FunctionUIBattleSkillViewSkillJoystick sListenerReleaseHD, UIBattleSkill.FunctionUIBattleSkillViewSkillJoystick sListenerWeaponHD)
		{
		}

		public void show(UIBattleSkillViewSkill sSkill)
		{
		}

		public void hide()
		{
		}

		private void showView()
		{
		}

		public void eventUpdate()
		{
		}
	}
}
