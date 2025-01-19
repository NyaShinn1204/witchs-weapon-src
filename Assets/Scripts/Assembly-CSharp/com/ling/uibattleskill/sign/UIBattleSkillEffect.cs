using System.Collections.Generic;
using UnityEngine;

namespace com.ling.uibattleskill.sign
{
	public class UIBattleSkillEffect : MonoBehaviour
	{
		private class UIBattleSkillEffectWeapon
		{
			public float time;

			public GameObject viewSelect;

			public GameObject viewDurability;

			public UISprite viewWitch;

			public UISprite viewWeapon;

			public UISprite viewWeaponFailure;

			private int _animType;

			private float[] _animTime;

			public bool eventView(bool sIsLast)
			{
				return false;
			}
		}

		private const string SKILL_FLASH = "UI/Effect/UI_effects_weapon_change";

		private const string SKILL_FLASH_WEAPON = "UI/Effect/UI_effects_weapon_Scaler";

		private static UIBattleSkillEffect _instance;

		private List<UIBattleSkillEffectWeapon> _eventWeapon;

		private static UIBattleSkillEffect instance
		{
			get
			{
				return null;
			}
		}

		private static void SkillFlash(GameObject parent, UIBattleSkillViewSkill battleSkillViewSkill)
		{
		}

		public static void showChangeWeapon(GameObject sViewSelect, GameObject sViewDurability, UISprite sViewWitch, UISprite sViewWeapon, UISprite sViewWeaponFailure, UIBattleSkillViewSkill battleSkillViewSkill)
		{
		}

		public static void showReleaseSkill(GameObject sView)
		{
		}

		private void Update()
		{
		}

		private void eventWeapon()
		{
		}
	}
}
