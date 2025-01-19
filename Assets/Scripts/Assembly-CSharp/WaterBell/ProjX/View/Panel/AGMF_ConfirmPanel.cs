using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMF_ConfirmPanel : UIPanelSingle
	{
		public UILabel levelProgressLabel;

		public UILabel valueLabel;

		public UILabel needCurrenctLabel;

		public UILabel ruleLabel;

		public UIGrid levelListGrid;

		public UILabel titleLabel;

		private List<GameObject> levelListsSelect;

		private List<GameObject> levelListsDisabled;

		private int selectIndex;

		[NonSerialized]
		public static int selectLevel;

		public ButtonEx noButton;

		public ButtonEx yesButton;

		public ButtonEx okButton;

		private Action ButtonYesClickEvent;

		private Action ButtonNoClickEvent;

		private new void Awake()
		{
		}

		private void OnButtonNoClick()
		{
		}

		private void OnButtonYesClick()
		{
		}

		private void ClickLevelItem(GameObject obj)
		{
		}

		private void InitLevel()
		{
		}

		public void OpenPanel(int mode, int levelProgress, Action yesEventCallBack)
		{
		}
	}
}
