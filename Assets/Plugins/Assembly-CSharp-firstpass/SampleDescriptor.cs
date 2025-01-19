using System;
using UnityEngine;

public sealed class SampleDescriptor
{
	public bool IsLabel { get; set; }

	public Type Type { get; set; }

	public string DisplayName { get; set; }

	public string Description { get; set; }

	public string CodeBlock { get; set; }

	public bool IsSelected { get; set; }

	public GameObject UnityObject { get; set; }

	public bool IsRunning
	{
		get
		{
			return false;
		}
	}

	public SampleDescriptor(Type type, string displayName, string description, string codeBlock)
	{
	}

	public void CreateUnityObject()
	{
	}

	public void DestroyUnityObject()
	{
	}
}
