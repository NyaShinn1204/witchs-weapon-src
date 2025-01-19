using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_EnergyBar : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public float BarProgress;

	[HideInInspector]
	public float _Value2;

	[HideInInspector]
	public float _Value3;

	[HideInInspector]
	public float _Value4;

	[HideInInspector]
	public float _Value5;

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
