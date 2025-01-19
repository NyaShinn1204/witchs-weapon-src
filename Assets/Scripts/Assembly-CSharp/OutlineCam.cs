using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class OutlineCam : MonoBehaviour
{
	public int Iterations;

	public float Spread;

	public Camera outterLineCamera;

	public Shader compositeShader;

	private Material m_CompositeMaterial;

	public Shader blurShader;

	private Material m_BlurMaterial;

	public Shader cutoffShader;

	private Material m_cutoffMaterial;

	public Shader blackShader;

	private Material m_outterLineMat;

	private RenderTexture outterLineTexture;

	private bool inSwitch;

	protected Material compositeMaterial
	{
		get
		{
			return null;
		}
	}

	protected Material blurMaterial
	{
		get
		{
			return null;
		}
	}

	protected Material cutoffMaterial
	{
		get
		{
			return null;
		}
	}

	protected Material outterLineMat
	{
		get
		{
			return null;
		}
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	private void OnPreRender()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private void OnPostRender()
	{
	}

	[DebuggerHidden]
	private IEnumerator GenTex2D()
	{
		return null;
	}
}
