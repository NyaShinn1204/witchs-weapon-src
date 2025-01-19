using System;
using UnityEngine;

public class LightMapData : MonoBehaviour
{
	[Serializable]
	public struct RendererInfo
	{
		public Renderer renderer;

		public int lightmapIndex;

		public Vector4 lightmapOffsetScale;
	}

	[SerializeField]
	public RendererInfo m_RendererInfo;

	public void GetInfo()
	{
	}

	public void SetInfo()
	{
	}
}
