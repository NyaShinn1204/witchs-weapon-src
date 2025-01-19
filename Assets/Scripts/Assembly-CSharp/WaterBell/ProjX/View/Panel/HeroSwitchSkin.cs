using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroSwitchSkin : MonoBehaviour
	{
		private static HashSet<long> loadedSet;

		private const string MODEL_PATH = "UI/Model/";

		private const string COLL_PATH = "UI/body_collider";

		private const string CLOTH_OVERRIDE_CONTROLLER_PATH = "UI/Data/HeroClothAnim";

		private const string CLOTH_OVERRIDE_ANIM_PATH = "UI/Model/AnimController/";

		public static HeroSwitchSkin current;

		[SerializeField]
		private Transform m_Model;

		public bool isInUILayer;

		public Action<HeroSwitchSkin> OnSkinChangeEvnt;

		[SerializeField]
		private long currentID;

		public Transform Model
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		public void SetSkin(long skinID)
		{
		}

		public void SetSkin(long skinID, bool immediatelyLoadResource)
		{
		}

		private void LoadModel()
		{
		}
	}
}
