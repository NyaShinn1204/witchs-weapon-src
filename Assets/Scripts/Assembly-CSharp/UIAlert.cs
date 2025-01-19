using System.Runtime.InteropServices;

public class UIAlert : GUtilUISuper
{
	public class UIAlertInfo
	{
		public int size;

		public int spacing;

		public string info;

		public UIAlertInfo(int sSize, string sInfo, int sSpacing = 4, bool isCheckBox = false)
		{
		}
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DelegateCheck(bool _selected);

	private string _title;

	private string _info;

	private UIAlertInfo[] _infoFormat;

	private FunctionUnArgs _listenerYes;

	private FunctionUnArgs _listenerNo;

	private bool _lockBackClick;

	private bool selected;

	private UIToggle toggle;

	private bool _showCheckBox;

	private string _checkLabel;

	private string _checkRemindLabel;

	private DelegateCheck _delegateCheck;

	private void Awake()
	{
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	protected override void animShow()
	{
	}

	protected override void animClose()
	{
	}

	private void back()
	{
	}

	private void btnNo()
	{
	}

	private void btnYes()
	{
	}

	public void setData(string sTitle, string sInfo)
	{
	}

	public void setDataFormat(string sTitle, UIAlertInfo[] sInfo, bool showCheckBox = false, string checkLabel = "", string checkRemind = "")
	{
	}

	public void setListener(FunctionUnArgs sListenerYes, FunctionUnArgs sListenerNo)
	{
	}

	public void setCheckListener(DelegateCheck delegateCheck)
	{
	}

	public void setButton(bool sLockBackClick, string sYes, string sNo)
	{
	}
}
