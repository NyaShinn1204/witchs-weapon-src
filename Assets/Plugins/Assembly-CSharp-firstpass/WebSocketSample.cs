using System;
using BestHTTP.WebSocket;
using UnityEngine;

public class WebSocketSample : MonoBehaviour
{
	private string address;

	private string msgToSend;

	private string Text;

	private WebSocket webSocket;

	private Vector2 scrollPos;

	private void OnDestroy()
	{
	}

	private void OnGUI()
	{
	}

	private void OnOpen(WebSocket ws)
	{
	}

	private void OnMessageReceived(WebSocket ws, string message)
	{
	}

	private void OnClosed(WebSocket ws, ushort code, string message)
	{
	}

	private void OnError(WebSocket ws, Exception ex)
	{
	}
}
