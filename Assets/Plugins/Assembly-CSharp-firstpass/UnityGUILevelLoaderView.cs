using UnityEngine;

public class UnityGUILevelLoaderView : LevelLoaderView
{
	public Texture progressBackground;

	public Texture progressForground;

	public Texture background;

	public string[] layersToDisable;

	private LayerMask _oldMask;

	private bool _areLayersDisabled;

	public override void Bind()
	{
	}

	private void _Progress_PropertyChanged(float value)
	{
	}

	public void OnGUI()
	{
	}

	private void DrawProgress(Vector2 location, Vector2 size, float progress)
	{
	}
}
