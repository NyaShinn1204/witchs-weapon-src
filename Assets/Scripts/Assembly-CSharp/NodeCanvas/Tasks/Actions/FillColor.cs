using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class FillColor : GuideTask
	{
		[SerializeField]
		private bool isChange;

		[SerializeField]
		private string from;

		[SerializeField]
		private string to;

		[SerializeField]
		private float time;

		[SerializeField]
		private ColorLayerType layerType;

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

		private Color String2Color(string str)
		{
			return default(Color);
		}
	}
}
