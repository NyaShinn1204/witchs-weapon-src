using System;
using BestHTTP.SignalR;
using BestHTTP.SignalR.Hubs;
using UnityEngine;

internal class DemoHubSample : MonoBehaviour
{
	private readonly Uri URI;

	private Connection signalRConnection;

	private DemoHub demoHub;

	private TypedDemoHub typedDemoHub;

	private Hub vbDemoHub;

	private string vbReadStateResult;

	private Vector2 scrollPos;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGUI()
	{
	}
}
