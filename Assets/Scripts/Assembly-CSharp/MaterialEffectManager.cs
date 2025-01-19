using System.Collections.Generic;
using UnityEngine;

public class MaterialEffectManager
{
	private struct MaterialEffect
	{
		public Material mat;

		public uint count;
	}

	private static MaterialEffectManager _instance;

	public const float SATURATION_PAUSE = 0.6f;

	public const float BRIGHTNESS_PAUSE = 0.6f;

	private Dictionary<Renderer, Material[]> mesh2shared;

	private Dictionary<Material, MaterialEffect> shared2Unique;

	public static MaterialEffectManager getInstance()
	{
		return null;
	}

	public void AddGrayScale(GameObject go)
	{
	}

	public void RemoveGrayScale(GameObject go)
	{
	}

	public void Clear()
	{
	}
}
