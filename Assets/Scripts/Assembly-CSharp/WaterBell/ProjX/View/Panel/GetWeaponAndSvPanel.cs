using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetWeaponAndSvPanel : UIPanelSingle
	{
		private const string PREFAB_PATH = "UI/Prefab/GetWeaponAndSvPanel";

		private static GetWeaponAndSvPanel current;

		public GetWeaponAnimPanel weaponAnim;

		public GetServantAnimPanel servantAnim;

		private Action onCloseEvent;

		[SerializeField]
		private LotteryLootData lootData;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static GetWeaponAndSvPanel GetInstance()
		{
			return null;
		}

		public static bool IsPlayAnim(LotteryLootData lootData)
		{
			return false;
		}

		public void OpenPanel(LotteryLootData lootData, Action onCloseEvent = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
