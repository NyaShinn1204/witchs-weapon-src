using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public abstract class DoTweenObject : MonoBehaviour
	{
		protected Tweener m_Tweener;

		public abstract void Change();
	}
}
