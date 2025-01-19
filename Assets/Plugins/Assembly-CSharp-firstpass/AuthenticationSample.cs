using System;
using BestHTTP.SignalR;
using UnityEngine;

internal class AuthenticationSample : MonoBehaviour
{
	private readonly Uri URI;

	private Connection signalRConnection;

	private string userName;

	private string role;

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

	private void signalRConnection_OnConnected(Connection manager)
	{
	}

	private void Restart()
	{
	}
}
