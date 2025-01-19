using NodeCanvas.Framework;
using NodeCanvas.GuideLessonTrees;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class C_speakAside : GuideTask, ISaveArgs
	{
		[SerializeField]
		private bool enableSentenceMapping;

		[SerializeField]
		private string spName;

		[SerializeField]
		private string wordStr;

		[SerializeField]
		private int sentenceIdx;

		[SerializeField]
		private bool isHideConversation;

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

		protected override void OnExecute()
		{
		}

		private void SpeakAside()
		{
		}

		private GuideRound SearchRoundOwner()
		{
			return null;
		}

		public string I_GetRoleName()
		{
			return null;
		}
	}
}
