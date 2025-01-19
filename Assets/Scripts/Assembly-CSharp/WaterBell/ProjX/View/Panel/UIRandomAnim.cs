using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIRandomAnim : MonoBehaviour
	{
		public Ease ease;

		public int rate;

		public int loop;

		public Transform select;

		private Tween m_Tweener;

		public Action<Transform> OnCurrentSelect;

		public Action<Transform> OnAnimComplete;

		public void PlayAnim(List<Transform> posList, Transform selectAtLast)
		{
		}
	}
}
