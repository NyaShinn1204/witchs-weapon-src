using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIPanelBase : CommonScenePanel
	{
		public AssetsManager.AssetsType myAssetType;

		public long id;

		protected UIDataBase mData;

		public bool isLock;

		public bool isOpen;

		public virtual UIDataBase Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Bind(UIDataBase data)
		{
		}

		public virtual void Unbind(UIDataBase data)
		{
		}

		public void UpdatePanelDelay()
		{
		}

		[DebuggerHidden]
		private IEnumerator CallUpdatePanel()
		{
			return null;
		}

		public virtual void UpdatePanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public virtual void ResetPanel()
		{
		}

		public virtual void GotoPrevStep()
		{
		}

		public static UIPanelBase Create(UIDataBase itemData, float scale = 0.8f, Transform parent = null, AssetsManager.AssetsType sType = AssetsManager.AssetsType.UIPrefab)
		{
			return null;
		}

		public void CreatePrefab(Transform parent, int count, int gridChildCount, GameObject prefab)
		{
		}
	}
}
