using UnityEngine;

public class ColorLayer : MonoBehaviour
{
	public UISprite texture;

	public TweenColor tweenColor;

	private static ColorLayer instance;

	public static ColorLayer GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Hide()
	{
	}

	public void Show(ColorLayerType layerType, bool isChange, Color from, Color to, float time)
	{
	}
}
