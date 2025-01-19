using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class PlayVideo : GuideTask
	{
		[SerializeField]
		private string Name;

		private bool isCheck;

		private VideoManager videoManager;

		[SerializeField]
		private VideoManager.MovieControlMode mode;

		public bool isLanguage;

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

		protected override void OnUpdate()
		{
		}
	}
}
