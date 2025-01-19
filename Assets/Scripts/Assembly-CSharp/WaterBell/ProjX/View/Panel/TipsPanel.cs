using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class TipsPanel : UIPanelSingle
	{
		public const string GENERAL = "UI/Prefab/Tips/GeneralTips";

		public const string SKILL = "UI/Prefab/Tips/SkillTips";

		public const string RANK = "UI/Prefab/Tips/RankTips";

		public const string MOB = "UI/Prefab/Tips/MobTips";

		public const string RES = "UI/Prefab/Tips/ResTips/ResTips";

		public const string Fashion = "UI/Prefab/Tips/ResTips/FashionTips";

		public const string EQUIP = "UI/Prefab/Tips/ResTips/EquipTips";

		public const string SERVANT_FAVOR = "UI/Prefab/Tips/ResTips/ServantFavorTips";

		public const string ROLE_EXP = "UI/Prefab/Tips/ResTips/RoleExpTips";

		public const string SERVANT = "UI/Prefab/Tips/ResTips/ServantTips";

		public const string VIP_EXP = "UI/Prefab/Tips/ResTips/VipExpTips";

		public const string WEAPON = "UI/Prefab/Tips/ResTips/WeaponTips";

		public const string MONTH_CARD = "UI/Prefab/Tips/ResTips/MonthCardTips";

		public const string WEAPON_AND_SERVANT = "UI/Prefab/Tips/ResTips/WeaponAndSvTips";

		private static TipsPanel current;

		public GameObject tipsContainer;

		public ButtonEx closeButton;

		private TipsBase cacheTipsBase;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private new void OnDestroy()
		{
		}

		[DebuggerHidden]
		private IEnumerator ClosePanelDelay()
		{
			return null;
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public static TipsPanel GetInstance()
		{
			return null;
		}

		public void OpenPanel<T>(T data, Transform target) where T : TipsBaseData
		{
		}

		[DebuggerHidden]
		private IEnumerator SetPanelAlphaDelay()
		{
			return null;
		}
	}
}
