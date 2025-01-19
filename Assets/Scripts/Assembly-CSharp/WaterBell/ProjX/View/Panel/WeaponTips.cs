using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponTips : ResTips
	{
		public UILabel weaponTypeLabel;

		public UILabel servantNameLabel;

		public UISprite servantIcon;

		protected long targetID;

		public override void OpenPanel(TipsBaseData data, Transform target)
		{
		}
	}
}
