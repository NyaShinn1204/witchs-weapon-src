using System.Collections.Generic;
using UnityEngine;

public class UILoadCutAssets : GUtilUISuper
{
	private List<GUtilAssetsCut.Info> _path;

	private FunctionListenerEvent _succeedHD;

	private FunctionListenerEvent _failedHD;

	private GUtilListenerEvent _event;

	private WWW _www;

	private int _wwwIndex;

	private int _wwwLoadMax;

	private int _wwwLoadCurrent;

	private UISprite _viewScroll;

	private UILabel _viewInfo;

	private int _errorTimes;

	private int _errorTimeCount;

	private string _error;

	private string _infoStr;

	public static void Load(List<GUtilAssetsCut.Info> sPath, FunctionListenerEvent sSucceed, FunctionListenerEvent sFailed, GUtilListenerEvent sEvent)
	{
	}

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	private void eventLoad()
	{
	}

	private void eventView()
	{
	}

	private void eventAction()
	{
	}
}
