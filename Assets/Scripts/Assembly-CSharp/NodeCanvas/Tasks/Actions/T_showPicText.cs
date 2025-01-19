using NodeCanvas.Framework;
using UnityEngine;
using WaterBell.ProjX.Guide.Content;

namespace NodeCanvas.Tasks.Actions
{
	public class T_showPicText : GuideTask, ISaveArgs
	{
		public string picName;

		public string word;

		public string arg;

		public PicTextLayer.Style style;

		public PicTextLayer.ArrowStyle arrowStyle;

		public PicTextLayer.ArrowPositionStyle arrowPositionStyle;

		public UIAnchor.Side side;

		public Vector2 offset;

		public float offsetArrow;

		public PicTextLayer.CloseStyle closeStyle;

		public PicTextLayer.ArrowCloseStyle arrowCloseStyle;

		public bool isLanguage;

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

		protected string _word
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
