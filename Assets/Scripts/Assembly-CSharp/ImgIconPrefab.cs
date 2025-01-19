using UnityEngine;

public class ImgIconPrefab : MonoBehaviour
{
	public UISprite img;

	public UITexture texture;

	public ButtonEx btn;

	public SelectGuildImgControl.Btns currentBtn;

	public string spriteName;

	public Transform selectIcon;

	public static ImgIconPrefab current;

	private void Awake()
	{
	}

	public void SetItemInfo(SelectGuildImgControl.Btns _btn, string _name, string currentName)
	{
	}

	private void ItemClick()
	{
	}

	public void SetSelectItemUI()
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	private void Draw()
	{
	}
}
