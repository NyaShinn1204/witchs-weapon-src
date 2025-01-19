using UnityEngine;

public class UILoadingAssetBundle : MonoBehaviour, INotifyErr, INotify
{
	public UISprite _scroll;

	public UISprite _scrollBg;

	public UISprite _scrollLight;

	public UILabel _labelState;

	public UISprite _labelBG;

	public UISprite _barBG;

	private bool _isStartDownloadingAssets;

	private bool isDownloadResTaskBegin;

	private bool isDownloadResTaskEnd;

	private NetEnvRemote env;

	private bool isTask1SuccFinish;

	private void Start()
	{
	}

	private void StartTask1()
	{
	}

	private void StartTask2()
	{
	}

	private void Update()
	{
	}

	private void initNetRouter()
	{
	}

	public void OnTask1Finish(int error)
	{
	}

	private void CheckIsAllFinished()
	{
	}

	private void SetLoadingUIVisble(bool flag)
	{
	}

	private void ShowDownloadState(bool flag)
	{
	}

	public void NetworkError()
	{
	}

	public void NetworkErrorHandle()
	{
	}

	public void NetworkErrorGetIndex()
	{
	}

	public void NetworkErrorHandleGetIndex()
	{
	}

	public void ReplaceOptional()
	{
	}

	public void OnCheck(bool _selected)
	{
	}

	public void ReplaceOptionalSkip()
	{
	}

	public void ReplaceOptionalConfirm()
	{
	}

	private void TryUpdateDownloadState()
	{
	}

	public void notify(int resCount)
	{
	}

	public void notifyError(int param = 0)
	{
	}

	public void notifyTimeout()
	{
	}

	public void notifyAbort()
	{
	}

	private void __nofify__(int param = 0)
	{
	}

	private void GetSerVersionSucceed(C2RM sC2RM)
	{
	}

	private void GetSerVersionError(C2RM sC2RM)
	{
	}

	private void GetAccAddrError(C2RM sC2RM)
	{
	}

	private void GetSerUrl()
	{
	}

	private void GetSerUrlSucceed(C2RM sC2RM)
	{
	}

	private void GetSerUrlError(C2RM sC2RM)
	{
	}

	private void CheckLocaVersion()
	{
	}

	private void CheckMemory()
	{
	}

	private void CheckLoad()
	{
	}

	private void MsgMemoryFull()
	{
	}

	private void MsgMemoryFullYesHD()
	{
	}

	private void MsgLoad()
	{
	}

	private void MsgLoadYesHD()
	{
	}

	private void MsgLoadAPK()
	{
	}

	private void MsgLoadAPKYesHD()
	{
	}

	private void MsgNetError()
	{
	}

	private void MsgNetErrorYESHD()
	{
	}

	private void MsgReDownLoad()
	{
	}

	private void MsgReDownLoadYesHD()
	{
	}

	private void MsgGetVersion()
	{
	}

	private void MsgGetVersionYesHD()
	{
	}
}
