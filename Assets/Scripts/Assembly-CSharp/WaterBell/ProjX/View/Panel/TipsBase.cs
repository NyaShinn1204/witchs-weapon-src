using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public abstract class TipsBase : MonoBehaviour
	{
		protected const string CONTAINER = "Container";

		protected const string BG = "Container/Bg";

		[Space]
		public Vector2 offset;

		protected UIWidget container;

		protected UISprite bg;

		protected UIPanel panelRegion;

		protected TipsBaseData data;

		protected Transform target;

		[NonSerialized]
		public bool isAutoClose;

		protected virtual void Awake()
		{
		}

		public virtual void OpenPanel(TipsBaseData data, Transform target)
		{
		}

		public virtual void RePosition()
		{
		}

		public void ResizeBg()
		{
		}

		public virtual void ClosePanel()
		{
		}

		private void Update()
		{
		}
	}
}
