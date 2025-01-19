using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class IntensifyPanel : UIPanelSingle
	{
		public static IntensifyPanel current;

		public UIResSpriteExGrid itemContainer;

		public UILabel currentLevelLabel;

		public BarBase expBar;

		public UILabel goldLabel;

		public UILabel limitLevelLabel;

		public GameObject newLevelContainer;

		public GameObject emptyTips;

		public GameObject valuesContainer;

		public UILabel atkPrevLabel;

		public UILabel atkNextLabel;

		public IntensifyPropItem prop;

		public IntensifyPropItem prop2;

		public ButtonEx intensifyButton;

		public ButtonEx closeButton;

		public ButtonEx bgCloseButton;

		public ButtonEx helpButton;

		public LoadUIPanelSingle intensifySuccLoader;

		public LoadUIPanelSingle helpLoader;

		private long servantId;

		private long weaponId;

		private long weaponDegreeId;

		private Dictionary<long, int> selectLootDict;

		private List<UIDataBase> lootDataList;

		private int currentLevel;

		private int nextLevel;

		private int maxLevel;

		private long currentExp;

		private int gold;

		private WeaponDevelopInfo weaponDevelopInfo;

		private CurrentServantWeaponAddExpView currentServantWeaponAddExpView;

		private SingleServantWeaponView singleServantWeaponView;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void ItemIncrease(IntensifyLootItem loot, int num)
		{
		}

		private void ItemIncreaseFresh(IntensifyLootItem loot, WeaponExpItemInfo weaponExpItemInfo)
		{
		}

		public void ItemDecrease(IntensifyLootItem loot, int num)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void Refresh()
		{
		}

		private double GetWeaponAttackModulus(long svID, int weaponLevel)
		{
			return 0.0;
		}

		private void BindUFrame()
		{
		}
	}
}
