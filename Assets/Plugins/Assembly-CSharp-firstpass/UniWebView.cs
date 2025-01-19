using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PageStartedDelegate(UniWebView webView, string url);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PageFinishedDelegate(UniWebView webView, int statusCode, string url);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PageErrorReceivedDelegate(UniWebView webView, int errorCode, string errorMessage);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void MessageReceivedDelegate(UniWebView webView, UniWebViewMessage message);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate bool ShouldCloseDelegate(UniWebView webView);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void KeyCodeReceivedDelegate(UniWebView webView, int keyCode);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OrientationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnWebContentProcessTerminatedDelegate(UniWebView webView);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	[Obsolete]
	public delegate void OreintationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	private string id;

	private UniWebViewNativeListener listener;

	private bool isPortrait;

	[SerializeField]
	private string urlOnStart;

	[SerializeField]
	private bool showOnStart;

	[SerializeField]
	private bool fullScreen;

	[SerializeField]
	private bool useToolbar;

	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition;

	private Dictionary<string, Action> actions;

	private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions;

	[SerializeField]
	private Rect frame;

	[SerializeField]
	private RectTransform referenceRectTransform;

	private bool started;

	private Color backgroundColor;

	public Rect Frame
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public RectTransform ReferenceRectTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Url
	{
		get
		{
			return null;
		}
	}

	public bool CanGoBack
	{
		get
		{
			return false;
		}
	}

	public bool CanGoForward
	{
		get
		{
			return false;
		}
	}

	public Color BackgroundColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float Alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public event PageStartedDelegate OnPageStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event PageFinishedDelegate OnPageFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public event PageErrorReceivedDelegate OnPageErrorReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event MessageReceivedDelegate OnMessageReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event ShouldCloseDelegate OnShouldClose
	{
		add
		{
		}
		remove
		{
		}
	}

	public event KeyCodeReceivedDelegate OnKeyCodeReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event OrientationChangedDelegate OnOrientationChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public event OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public event OrientationChangedDelegate OnOreintationChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public void UpdateFrame()
	{
	}

	private Rect NextFrameRect()
	{
		return default(Rect);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Load(string url, bool skipEncoding = false, string readAccessURL = null)
	{
	}

	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false)
	{
	}

	public void Reload()
	{
	}

	public void Stop()
	{
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void SetOpenLinksInExternalBrowser(bool flag)
	{
	}

	public bool Show(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool Hide(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool AnimateTo(Rect frame, float duration, float delay = 0f, Action completionHandler = null)
	{
		return false;
	}

	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void AddUrlScheme(string scheme)
	{
	}

	public void RemoveUrlScheme(string scheme)
	{
	}

	public void AddSslExceptionDomain(string domain)
	{
	}

	public void RemoveSslExceptionDomain(string domain)
	{
	}

	public void SetHeaderField(string key, string value)
	{
	}

	public void SetUserAgent(string agent)
	{
	}

	public string GetUserAgent()
	{
		return null;
	}

	public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior)
	{
	}

	public static void SetAllowAutoPlay(bool flag)
	{
	}

	public static void SetAllowInlinePlay(bool flag)
	{
	}

	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	public void CleanCache()
	{
	}

	public static void ClearCookies()
	{
	}

	public static void SetCookie(string url, string cookie, bool skipEncoding = false)
	{
	}

	public static string GetCookie(string url, string key, bool skipEncoding = false)
	{
		return null;
	}

	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	public void SetShowSpinnerWhileLoading(bool flag)
	{
	}

	public void SetSpinnerText(string text)
	{
	}

	public void SetHorizontalScrollBarEnabled(bool enabled)
	{
	}

	public void SetVerticalScrollBarEnabled(bool enabled)
	{
	}

	public void SetBouncesEnabled(bool enabled)
	{
	}

	public void SetZoomEnabled(bool enabled)
	{
	}

	public void AddPermissionTrustDomain(string domain)
	{
	}

	public void RemovePermissionTrustDomain(string domain)
	{
	}

	public void SetBackButtonEnabled(bool enabled)
	{
	}

	public void SetUseWideViewPort(bool flag)
	{
	}

	public void SetLoadWithOverviewMode(bool flag)
	{
	}

	public void SetImmersiveModeEnabled(bool enabled)
	{
	}

	public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false)
	{
	}

	public void SetToolbarDoneButtonText(string text)
	{
	}

	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	public void SetWindowUserResizeEnabled(bool enabled)
	{
	}

	public void GetHTMLContent(Action<string> handler)
	{
	}

	public void SetAllowFileAccessFromFileURLs(bool flag)
	{
	}

	public void SetAllowHTTPAuthPopUpWindow(bool flag)
	{
	}

	public void SetCalloutEnabled(bool enabled)
	{
	}

	public void SetSupportMultipleWindows(bool enabled)
	{
	}

	public void SetDragInteractionEnabled(bool enabled)
	{
	}

	public void Print()
	{
	}

	public void ScrollTo(int x, int y, bool animated)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	internal void InternalOnShowTransitionFinished(string identifier)
	{
	}

	internal void InternalOnHideTransitionFinished(string identifier)
	{
	}

	internal void InternalOnAnimateToFinished(string identifier)
	{
	}

	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageStarted(string url)
	{
	}

	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnMessageReceived(string result)
	{
	}

	internal void InternalOnWebViewKeyDown(int keyCode)
	{
	}

	internal void InternalOnShouldClose()
	{
	}

	internal void InternalWebContentProcessDidTerminate()
	{
	}
}
