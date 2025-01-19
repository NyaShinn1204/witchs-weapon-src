using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_Shiny_Reflect : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	[HideInInspector]
	public Texture2D __MainTex2;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public float Light;

	[HideInInspector]
	public float LightSize;

	[HideInInspector]
	public bool UseShinyCurve;

	[HideInInspector]
	public AnimationCurve ShinyLightCurve;

	[HideInInspector]
	public float AnimationSpeedReduction;

	[HideInInspector]
	public float Intensity;

	[HideInInspector]
	public float OnlyLight;

	[HideInInspector]
	public float LightBump;

	private float ShinyLightCurveTime;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private void Start()
	{
	}

	public void CallUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
