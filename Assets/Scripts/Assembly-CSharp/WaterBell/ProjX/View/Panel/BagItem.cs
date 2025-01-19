using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BagItem
	{
		public BagItemData itemData;

		public Transform itemObjTrans;

		public BagItem(BagItemData data, Transform trans)
		{
		}

		public void reset()
		{
		}

		public void UpdateItemView()
		{
		}

		public UIButton GetAddBtn()
		{
			return null;
		}

		public UIButton GetMinusBtn()
		{
			return null;
		}

		private void EnableMinusBtn()
		{
		}

		private void DisableMinusBtn()
		{
		}

		public void ClickMinusBtn()
		{
		}

		private void UpdateItemLabel()
		{
		}

		private void UpdateMinusBtn()
		{
		}

		public void ConsumedOneByFav()
		{
		}

		public void ReturnedOneByFav()
		{
		}
	}
}
