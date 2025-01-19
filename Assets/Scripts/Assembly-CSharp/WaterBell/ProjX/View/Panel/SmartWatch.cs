using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SmartWatch : UIPanelSingle
	{
		private static float hideButtonOffsetTarget;

		private static float showButtonOffsetTarget;

		private static readonly string path;

		private static SmartWatch s_Current;

		public Transform buttonContainer;

		public ButtonEx closeButton;

		public ButtonEx watchButton;

		public float radius;

		public float startAngle;

		public float endAgnle;

		private float buttonAngleOffsetTarget;

		private float buttonAngleOffset;

		private ButtonEx[] buttons;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static SmartWatch GetInstance()
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void CloseComplete()
		{
		}
	}
}
