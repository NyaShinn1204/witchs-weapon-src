using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using BestHTTP.SignalR.Hubs;
using UnityEngine;

internal sealed class ConnectionStatusSample : MonoBehaviour
{
	private readonly Uri URI;

	private Connection signalRConnection;

	private GUIMessageList messages;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGUI()
	{
	}

	private void signalRConnection_OnNonHubMessage(Connection manager, object data)
	{
	}

	private void signalRConnection_OnStateChanged(Connection manager, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	private void signalRConnection_OnError(Connection manager, string error)
	{
	}

	private void statusHub_OnMethodCall(Hub hub, string method, params object[] args)
	{
	}
}
