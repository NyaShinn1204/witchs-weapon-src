using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

public class ThreadManager
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	private delegate void ThreadSyncEvent(NotiData data);

	private static ThreadManager instance;

	private Thread thread;

	private Action<NotiData> func;

	private Stopwatch sw;

	private string currDownFile;

	private static readonly object m_lockObject;

	private static Queue<ThreadEvent> events;

	private ThreadSyncEvent m_SyncEvent;

	public static ThreadManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void AddEvent(ThreadEvent ev, Action<NotiData> func)
	{
	}

	private void OnSyncEvent(NotiData data)
	{
	}

	private void OnUpdate()
	{
	}

	private void OnDownloadFile(List<object> evParams)
	{
	}

	private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	private void OnExtractFile(List<object> evParams)
	{
	}

	private void OnDestroy()
	{
	}
}
