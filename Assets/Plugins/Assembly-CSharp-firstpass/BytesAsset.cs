using System.IO;
using UnityEngine;

public class BytesAsset : ScriptableObject
{
	[SerializeField]
	public byte[] bytes;

	[SerializeField]
	public bool isEncrypt;

	public string str
	{
		get
		{
			return null;
		}
	}

	public StreamReader streamReader
	{
		get
		{
			return null;
		}
	}

	public byte[] bytesEncrypt
	{
		get
		{
			return null;
		}
	}
}
