using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class C_roleSpeak : GuideTask, ISaveArgs
	{
		[SerializeField]
		private bool enableSentenceMapping;

		[SerializeField]
		private int _roleIdx;

		[SerializeField]
		private string faceStr;

		[SerializeField]
		private string spRoleName;

		[SerializeField]
		private string wordStr;

		[SerializeField]
		private int sentenceIdx;

		public bool isLanguage;

		public int roleIdx
		{
			get
			{
				return 0;
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

		public string I_GetRoleName()
		{
			return null;
		}

		public void ConvertFromSpeakAside(int sentenceIdx)
		{
		}

		protected override void OnExecute()
		{
		}

		private void RoleSpeak()
		{
		}
	}
}
