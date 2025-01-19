using UnityEngine;

public abstract class NGUISprite_Base : MonoBehaviour
{
	protected Material tempMaterial;

	protected Texture oldtex;

	protected UIAtlas oldAtlas;

	protected UISprite sprite;

	protected abstract Material getNewMaterial();

	protected abstract void UpdateMaterial();

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
