using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_4Gradients : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public Color _Color1;

	[HideInInspector]
	public Color _Color2;

	[HideInInspector]
	public Color _Color3;

	[HideInInspector]
	public Color _Color4;

	[HideInInspector]
	public float _Alpha;

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
