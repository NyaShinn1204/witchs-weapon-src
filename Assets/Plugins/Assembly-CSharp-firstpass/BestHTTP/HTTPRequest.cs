using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BestHTTP.Authentication;
using BestHTTP.Cookies;
using BestHTTP.Forms;
using Org.BouncyCastle.Crypto.Tls;
using UnityEngine;

namespace BestHTTP
{
	public sealed class HTTPRequest : IEnumerator, IEnumerator<HTTPRequest>, IDisposable
	{
		public static readonly byte[] EOL;

		public static readonly string[] MethodNames;

		public static int UploadChunkSize;

		public OnUploadProgressDelegate OnUploadProgress;

		public OnDownloadProgressDelegate OnProgress;

		public OnRequestFinishedDelegate OnUpgraded;

		private List<Cookie> customCookies;

		private OnBeforeRedirectionDelegate onBeforeRedirection;

		private OnBeforeHeaderSendDelegate _onBeforeHeaderSend;

		private bool isKeepAlive;

		private bool disableCache;

		private bool cacheOnly;

		private int streamFragmentSize;

		private bool useStreaming;

		private HTTPFormBase FieldCollector;

		private HTTPFormBase FormImpl;

		HTTPRequest IEnumerator<HTTPRequest>.Current
		{
			get
			{
				return null;
			}
		}

		public Uri Uri { get; private set; }

		public HTTPMethods MethodType { get; set; }

		public byte[] RawData { get; set; }

		public Stream UploadStream { get; set; }

		public bool DisposeUploadStream { get; set; }

		public bool UseUploadStreamLength { get; set; }

		public bool IsKeepAlive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisableCache
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CacheOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseStreaming
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int StreamFragmentSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxFragmentQueueLength { get; set; }

		public OnRequestFinishedDelegate Callback { get; set; }

		public bool DisableRetry { get; set; }

		public bool IsRedirected { get; internal set; }

		public Uri RedirectUri { get; internal set; }

		public Uri CurrentUri
		{
			get
			{
				return null;
			}
		}

		public HTTPResponse Response { get; internal set; }

		public HTTPResponse ProxyResponse { get; internal set; }

		public Exception Exception { get; internal set; }

		public object Tag { get; set; }

		public Credentials Credentials { get; set; }

		public bool HasProxy
		{
			get
			{
				return false;
			}
		}

		public HTTPProxy Proxy { get; set; }

		public int MaxRedirects { get; set; }

		public bool UseAlternateSSL { get; set; }

		public bool IsCookiesEnabled { get; set; }

		public List<Cookie> Cookies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HTTPFormUsage FormUsage { get; set; }

		public HTTPRequestStates State { get; internal set; }

		public int RedirectCount { get; internal set; }

		public TimeSpan ConnectTimeout { get; set; }

		public TimeSpan Timeout { get; set; }

		public bool EnableTimoutForStreaming { get; set; }

		public bool EnableSafeReadOnUnknownContentLength { get; set; }

		public int Priority { get; set; }

		public ICertificateVerifyer CustomCertificateVerifyer { get; set; }

		public IClientCredentialsProvider CustomClientCredentialsProvider { get; set; }

		public List<string> CustomTLSServerNameList { get; set; }

		public SupportedProtocols ProtocolHandler { get; set; }

		public bool TryToMinimizeTCPLatency { get; set; }

		internal long Downloaded { get; set; }

		internal long DownloadLength { get; set; }

		internal bool DownloadProgressChanged { get; set; }

		internal long UploadStreamLength
		{
			get
			{
				return 0L;
			}
		}

		internal long Uploaded { get; set; }

		internal long UploadLength { get; set; }

		internal bool UploadProgressChanged { get; set; }

		private Dictionary<string, List<string>> Headers { get; set; }

		public object Current
		{
			get
			{
				return null;
			}
		}

		public event Func<HTTPRequest, X509Certificate, X509Chain, bool> CustomCertificationValidator
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnBeforeRedirectionDelegate OnBeforeRedirection
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnBeforeHeaderSendDelegate OnBeforeHeaderSend
		{
			add
			{
			}
			remove
			{
			}
		}

		public HTTPRequest(Uri uri)
		{
		}

		public HTTPRequest(Uri uri, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		public void AddField(string fieldName, string value)
		{
		}

		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
		{
		}

		public void SetFields(WWWForm wwwForm)
		{
		}

		public void SetForm(HTTPFormBase form)
		{
		}

		public void ClearForm()
		{
		}

		private HTTPFormBase SelectFormImplementation()
		{
			return null;
		}

		public void AddHeader(string name, string value)
		{
		}

		public void SetHeader(string name, string value)
		{
		}

		public bool RemoveHeader(string name)
		{
			return false;
		}

		public bool HasHeader(string name)
		{
			return false;
		}

		public string GetFirstHeaderValue(string name)
		{
			return null;
		}

		public List<string> GetHeaderValues(string name)
		{
			return null;
		}

		public void RemoveHeaders()
		{
		}

		public void SetRangeHeader(int firstBytePos)
		{
		}

		public void SetRangeHeader(int firstBytePos, int lastBytePos)
		{
		}

		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback)
		{
		}

		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback, bool callBeforeSendCallback)
		{
		}

		private void SendHeaders(Stream stream)
		{
		}

		public string DumpHeaders()
		{
			return null;
		}

		internal byte[] GetEntityBody()
		{
			return null;
		}

		internal void SendOutTo(Stream stream)
		{
		}

		internal void UpgradeCallback()
		{
		}

		internal void CallCallback()
		{
		}

		internal bool CallOnBeforeRedirection(Uri redirectUri)
		{
			return false;
		}

		internal void FinishStreaming()
		{
		}

		internal void Prepare()
		{
		}

		internal bool CallCustomCertificationValidator(X509Certificate cert, X509Chain chain)
		{
			return false;
		}

		public HTTPRequest Send()
		{
			return null;
		}

		public void Abort()
		{
		}

		public void Clear()
		{
		}

		private void VerboseLogging(string str)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}
}
