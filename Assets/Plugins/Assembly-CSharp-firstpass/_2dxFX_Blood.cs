using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_Blood : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public Texture2D __MainTex2;

	[HideInInspector]
	public float TurnToLiquid;

	[HideInInspector]
	public float Heat;

	[HideInInspector]
	public float Speed;

	[HideInInspector]
	public float EValue;

	[HideInInspector]
	public float Light;

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
