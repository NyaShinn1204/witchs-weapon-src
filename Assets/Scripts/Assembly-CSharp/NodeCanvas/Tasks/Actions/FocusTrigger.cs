using NodeCanvas.Framework;
using UnityEngine;
using WaterBell.ProjX.Guide.Content;

namespace NodeCanvas.Tasks.Actions
{
	public class FocusTrigger : GuideTask, ISaveArgs
	{
		public string tip;

		public int xOffset;

		public int yOffset;

		public Stage.FocusStyle style;

		public bool isUseInLottery;

		[SerializeField]
		private bool enableSentenceMapping;

		[SerializeField]
		private int sentenceIdx;

		public int I_sentenceIdx
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string I_wordStr
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool I_enableSentenceMapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected string word
		{
			get
			{
				return null;
			}
		}

		public string I_GetRoleName()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}
	}
}
