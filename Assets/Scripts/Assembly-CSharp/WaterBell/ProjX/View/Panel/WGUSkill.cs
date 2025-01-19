using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class WGUSkill : UIPanelSingle
	{
		[Space]
		public UIPanelSingleContainer skillDetailContainer;

		public DoTweenLabel goldTween;

		[Space]
		public ServantCore.SingleServant servantData;

		public static WGUSkill current;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void UpdateGold()
		{
		}

		public void UpdateSkill()
		{
		}
	}
}
