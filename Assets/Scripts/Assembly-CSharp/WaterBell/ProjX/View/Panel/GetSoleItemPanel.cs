using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetSoleItemPanel : UIPanelSingle
	{
		private const string PREFAB_PATH = "UI/Prefab/GetSoleItemPanel";

		private static GetSoleItemPanel current;

		public Transform lootContainer;

		public ButtonEx closeButton;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static GetSoleItemPanel GetInstance()
		{
			return null;
		}

		public static bool IsPlayAnim(LotteryLootData lootData)
		{
			return false;
		}

		public void OpenPanel(LotteryLootData loot, Action onCloseEvent = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
