using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class T_showMask : GuideTask
	{
		private const float defaultMaskX = 100f;

		private const float defaultMaskY = 100f;

		public bool isSqrMask;

		public Vector2 maskExpectedSize;

		public Vector2 maskExpectedOffset;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
