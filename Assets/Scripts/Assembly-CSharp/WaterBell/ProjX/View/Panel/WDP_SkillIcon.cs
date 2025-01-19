using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WDP_SkillIcon : UIPanelSingle
	{
		private const string NORMAL_ICON = "Attack_skills";

		private const string SPELL_ICON = "Weapon_skills";

		public UISprite icon;

		public UILabel typeNameLabel;

		public GameObject lockIcon;

		public Action<int> OnClickEvent;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
