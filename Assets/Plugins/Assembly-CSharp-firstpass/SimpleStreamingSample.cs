using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using UnityEngine;

internal sealed class SimpleStreamingSample : MonoBehaviour
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

	private void signalRConnection_OnNonHubMessage(Connection connection, object data)
	{
	}

	private void signalRConnection_OnStateChanged(Connection connection, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	private void signalRConnection_OnError(Connection connection, string error)
	{
	}
}
