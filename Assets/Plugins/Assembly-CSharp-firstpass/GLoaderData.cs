using System.Collections.Generic;
using UnityEngine;

public class GLoaderData
{
	public GLoader.FunctionIDSign listener;

	public uint idSign;

	public List<string> fullUrl;

	public WWW www;

	public ResourceRequest resource;

	public void callListener()
	{
	}

	public void destroy()
	{
	}
}
