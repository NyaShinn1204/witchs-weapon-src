using System.Collections.Generic;
using UnityEngine;

namespace LuaFramework
{
	public class WrapGrid : MonoBehaviour
	{
		private Transform mTrans;

		private UIPanel mPanel;

		private UIScrollView mScroll;

		private bool mHorizontal;

		private bool mFirstTime;

		private List<Transform> mChildren;

		protected virtual void Start()
		{
		}

		public void InitGrid()
		{
		}

		protected virtual void OnMove(UIPanel panel)
		{
		}

		private void WrapContent()
		{
		}
	}
}
