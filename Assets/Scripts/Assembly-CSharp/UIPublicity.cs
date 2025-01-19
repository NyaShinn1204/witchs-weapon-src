using System.Collections.Generic;
using UnityEngine;

public class UIPublicity : GUtilUISuper
{
	private int[] mIDList;

	private string[] mNameList;

	private int mID;

	private Vector3 mInitPosition;

	private int mInitWidth;

	private UILabel mLabel;

	private UISprite mLine;

	private GameObject mMenu;

	private List<UISprite> hideLine;

	private List<UILabel> hideLabel;

	private List<UISprite> showLine;

	private List<UILabel> showLabel;

	private int lineIndex;

	private List<Dictionary<string, string>> lineDataCsv;

	private float lineHeight;

	private UISprite[] lineRow;

	private List<List<UISprite>> lineColor;

	private List<List<UILabel>> lineLabel;

	private Dictionary<string, UIButton> hashMenu;

	private int _tableMaxCol;

	private int tableMaxCol
	{
		get
		{
			return 0;
		}
	}

	public static void ShowPublicty(int sID, int[] sIDList, string[] sNameList)
	{
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	private void Update()
	{
	}

	private UILabel NewLabel()
	{
		return null;
	}

	private UISprite NewLine()
	{
		return null;
	}

	private void btnMenu(string[] sArg)
	{
	}

	private void clearView()
	{
	}

	private void btnBack()
	{
	}

	public override void destroy()
	{
	}
}
