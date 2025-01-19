using System.Collections.Generic;
using UnityEngine;

public class GuildImg : MonoBehaviour
{
	public UITexture material;

	public UITexture texture;

	public UISprite img;

	private List<TypeCsvEmblem> Emblems
	{
		get
		{
			return null;
		}
	}

	public void SetView(string _frameName, string _shadingName, string _imgName, int _frameColorIndex, int _shadingColorIndex, int _imgColorIndex)
	{
	}
}
