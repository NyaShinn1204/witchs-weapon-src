using System;
using UnityEngine;

[Serializable]
[ExecuteInEditMode]
public class _2dxFX_JellyAutoMove : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public float Heat;

	[HideInInspector]
	public float RandomPos;

	[HideInInspector]
	public float Inside;

	[HideInInspector]
	public float Stabilisation;

	[HideInInspector]
	public float Speed;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Vector3 SaveMove1;

	private Vector3 SaveMove2;

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
