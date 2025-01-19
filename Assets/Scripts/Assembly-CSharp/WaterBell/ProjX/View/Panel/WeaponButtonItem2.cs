using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponButtonItem2 : UIPanelSingle
	{
		public UITexture weaponIcon;

		public UISprite rare;

		public GameObject redPoint;

		public Transform offset;

		public UISprite awakeBG;

		[HideInInspector]
		public WeaponButtonItemData weaponData;

		public Action<long> OnClickEvent;

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
