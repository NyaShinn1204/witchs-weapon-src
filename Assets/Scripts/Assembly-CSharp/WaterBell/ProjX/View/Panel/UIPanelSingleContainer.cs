using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIPanelSingleContainer : MonoBehaviour
	{
		public string sourcePath;

		public AssetsManager.AssetsType sourceType;

		public bool isReposition;

		protected UIPanelBase source;

		protected UIGrid grid;

		protected UITable table;

		[SerializeField]
		protected List<UIPanelBase> childrenList;

		protected Transform poolContainer;

		[SerializeField]
		protected List<UIPanelBase> poolList;

		protected UIPanelBase current;

		protected Transform container;

		protected UICenterOnChild centerOnChild;

		protected bool init;

		public List<UIPanelBase> Children
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Init()
		{
		}

		public UIPanelBase OpenChild(long id, UIDataBase childData = null, bool closeOther = true)
		{
			return null;
		}

		public List<UIPanelBase> Create<Data>(List<Data> dataList, float scale = 1f) where Data : UIDataBase
		{
			return null;
		}

		protected UIPanelBase Get(UIDataBase data)
		{
			return null;
		}

		public virtual void Push2Pool(UIPanelBase item)
		{
		}

		public void CenterChild(UIPanelBase item)
		{
		}
	}
}
