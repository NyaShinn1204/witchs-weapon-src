using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponButtonItem : UIPanelSingle
	{
		public UITexture weaponIcon;

		public UISprite weaponSprite;

		public UISprite lockIcon;

		public WeaponButtonItemData weaponData;

		public UISprite mask;

		public UISprite weaponTypeIcon;

		public UISprite weaponQulityBg;

		public UISprite rare;

		public GameObject emptyIcon;

		public GameObject redPoint;

		public GameObject awakeIcon;

		public UISprite wpBgIcon;

		public Action<long> OnClickEvent;

		protected GameObject detailContainer;

		public ButtonEx Button
		{
			get
			{
				return null;
			}
		}

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
