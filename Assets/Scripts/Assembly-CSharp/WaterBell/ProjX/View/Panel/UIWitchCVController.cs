using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class UIWitchCVController : UIPanelSingle
	{
		public UILabel labelName;

		public UILabel labelCountry;

		public UILabel labelStyle;

		public WGU_CvItem item;

		public UIScrollBar slider;

		public UIScrollView scroll;

		public ButtonEx buttonClose;

		public ButtonEx buttonCloseBG;

		public UIGrid grid;

		private List<WGU_CvItem> listItem;

		public SingleServantPropertyView user;

		public static UIWitchCVController current;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Close()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
