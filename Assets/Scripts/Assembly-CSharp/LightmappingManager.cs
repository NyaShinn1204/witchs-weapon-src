using UnityEngine;

[ExecuteInEditMode]
public class LightmappingManager : MonoBehaviour
{
	[SerializeField]
	public Renderer[] sceneRenderers;

	public LightMapDataContainerObject lighmapDataContainer;

	[SerializeField]
	public Texture2D[] lightMapTexturesFar;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetLightMapTextures()
	{
	}

	public void SetLightMapData()
	{
	}
}
