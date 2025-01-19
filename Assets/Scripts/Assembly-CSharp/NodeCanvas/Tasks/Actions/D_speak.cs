using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class D_speak : GuideTask, ISaveArgs
	{
		[SerializeField]
		private bool enableSentenceMapping;

		[SerializeField]
		private string wordStr;

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
