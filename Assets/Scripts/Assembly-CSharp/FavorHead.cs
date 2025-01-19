using UnityEngine;

public class FavorHead : MonoBehaviour
{
	public ButtonEx Btn;

	public UISprite headIcon;

	public Transform SelectIcon;

	public static FavorHead current;

	private int level;

	private bool unLock;

	private void Awake()
	{
	}

	private void ClickHead()
	{
	}

	public void SetInfo(int _level, int _exp, bool _isSelect, bool _unLock)
	{
	}
}
