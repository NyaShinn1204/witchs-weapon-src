using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class B_speak : GuideTask, ISaveArgs
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
		private bool isBottomLine;

		[SerializeField]
		private NGUIText.Alignment align;

		[SerializeField]
		private int fontSize;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private UIWidget.Pivot pivot;

		[SerializeField]
		private Color col;

		public UIAnchor.Side side;

		public Vector4 relativeAndPixelOffset;

		public bool isBG;

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
