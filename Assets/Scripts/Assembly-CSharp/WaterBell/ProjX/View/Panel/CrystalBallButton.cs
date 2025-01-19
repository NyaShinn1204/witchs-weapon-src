using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CrystalBallButton : UIPanelSingle
	{
		public enum DetailTypes : uint
		{
			CountButton = 2u,
			DrawType = 4u,
			AdTex = 8u,
			All = uint.MaxValue
		}

		public static float a;

		public static float b;

		public Transform clickEffectContainer;

		public GameObject clickEffectSource;

		public GameObject clickEffectSource10;

		public Action<CrystalBallButton> OnDrawTypeClick;

		public Action<CrystalBallButton> OnMoveComplete;

		public float clickEffectDuration;

		public int freeCountTotal;

		public int freeCountCurrent;

		public DateTime nextFreeTime;

		public bool isFreeNow;

		public LuckDrawTypes drawType;

		public ButtonEx probButton;

		public UISprite adTex;

		private float angle;

		public float targetAngle;

		private Tweener tweener;

		private Dictionary<UIWidget, int> childrenDepthDict;

		private GameObject clickEffect;

		public bool isDebug;

		protected override void Awake()
		{
		}

		public void SyncData(DateTime nextFreeTime, int freeCountTotal, int freeCountCurrent)
		{
		}

		private void Update()
		{
		}

		public void Refresh()
		{
		}

		public void SetAngle(float targetAngle, float duration)
		{
		}

		public static Vector2 GetEllipsePoint(float p, float a, float b)
		{
			return default(Vector2);
		}

		public void SetAdState(bool isNormal)
		{
		}

		public float PlayClickEffect()
		{
			return 0f;
		}
	}
}
