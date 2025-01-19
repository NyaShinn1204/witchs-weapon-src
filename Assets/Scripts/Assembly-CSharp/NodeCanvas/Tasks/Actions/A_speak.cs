using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class A_speak : GuideTask, ISaveArgs
	{
		[SerializeField]
		private string wordStr;

		[SerializeField]
		private string icon;

		public float delaytime;

		private float passedtime;

		private bool isSpeak;

		public bool isOperate;

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

		protected override void OnUpdate()
		{
		}
	}
}
