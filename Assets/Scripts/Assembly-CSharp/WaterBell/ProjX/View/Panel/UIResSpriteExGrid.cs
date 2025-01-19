using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIResSpriteExGrid : MonoBehaviour
	{
		public enum Arrangement
		{
			Horizontal = 0,
			Vertical = 1
		}

		private static Rect VIEW_RECT;

		private static Camera s_Camera;

		public bool isCreatAll;

		public int cellWidth;

		public int cellHeight;

		public Arrangement arrangement;

		public int limit;

		public Vector2 containerOffset;

		public Vector3 itemScale;

		protected List<UIPanelBase> poolList;

		protected List<UIDataBase> m_Data;

		protected Transform poolContainer;

		protected UIWidget container;

		protected Dictionary<UIDataBase, UIPanelBase> drawingDataDict;

		protected List<UIDataBase> removeList;

		public List<UIDataBase> Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public List<T> GetChildren<T>() where T : UIPanelBase
		{
			return null;
		}

		public List<UIPanelBase> GetChildren()
		{
			return null;
		}

		public virtual void ItemDataChange(UIDataBase data)
		{
		}

		public void ResetPosition()
		{
		}

		protected virtual void Refresh()
		{
		}

		protected Vector2 GetDataPos(UIDataBase data)
		{
			return default(Vector2);
		}

		protected UIPanelBase Get(UIDataBase data)
		{
			return null;
		}

		protected void Push2Pool(UIDataBase data)
		{
		}

		protected void PushAll2Pool()
		{
		}
	}
}
