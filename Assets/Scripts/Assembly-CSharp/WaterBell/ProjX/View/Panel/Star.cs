using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class Star : MonoBehaviour
	{
		public enum DisplayModes
		{
			Normal = 0,
			Light = 1
		}

		public long id;

		public string starName;

		public List<Star> prevConnectList;

		public List<Star> nextConnectList;

		public StarSelectEffect selectEffect;

		private ConstantVisualSize m_ConstantVisualSize;

		public ConstantVisualSize ConstantVisualSize
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public bool Connect(Star star)
		{
			return false;
		}

		public void BreakConnect(Star star)
		{
		}

		public void PlayShowResultAnim(LotteryLootData data, float delay = 0.2f)
		{
		}

		[DebuggerHidden]
		private IEnumerator PlayShowResultAnimDelay(LotteryLootData data, float delay)
		{
			return null;
		}

		public void Init()
		{
		}

		public void ChangToLight()
		{
		}
	}
}
