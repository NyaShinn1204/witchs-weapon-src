using System.Collections.Generic;
using UnityEngine;

public class AtlasPool
{
	public enum UIAtlasTypes
	{
		Gray = 0
	}

	private static Shader _UNLIT_TRANSPARENT;

	private static Shader _UNLIT_TRANSPARENT_REMOVECOLOR;

	private static Dictionary<UIAtlas, UIAtlas> _FORMAT_GRAY_2_NORMAL;

	private static Dictionary<UIAtlas, UIAtlas> _FORMAT_NORMAL_2_GRAY;

	private static AtlasPool instance;

	private Dictionary<string, string> atlasDic;

	private Dictionary<string, UIAtlas> uiAtlasDict;

	public static AssetsManager.AssetsType loadType;

	public static Shader UNLIT_TRANSPARENT
	{
		get
		{
			return null;
		}
	}

	public static Shader UNLIT_TRANSPARENT_REMOVECOLOR
	{
		get
		{
			return null;
		}
	}

	public UIAtlas Item
	{
		get
		{
			return null;
		}
	}

	public UIAtlas GetAtlasCurrencyIcon
	{
		get
		{
			return null;
		}
	}

	public static UIAtlas FormatAtlasGray(UIAtlas sAtlas)
	{
		return null;
	}

	public static UIAtlas FormatAtlasNormal(UIAtlas sAtlas)
	{
		return null;
	}

	public static void clear()
	{
	}

	public void destory()
	{
	}

	public static AtlasPool getInstance()
	{
		return null;
	}

	private void InitAtlasPoolCSV()
	{
	}

	private void init()
	{
	}

	public UIAtlas getAtlast(string name, int FashionIndex = 1)
	{
		return null;
	}

	private string GetAchievementName(string _spriteName)
	{
		return null;
	}

	private string GetSpecialAtlasName(string _atlasName, string _name, string _sample, int _limit)
	{
		return null;
	}

	public UIAtlas getAtlas(string spriteName, UIAtlasTypes uiAtlasType)
	{
		return null;
	}

	public string getItemFrame(int quality)
	{
		return null;
	}

	public string getItemPieceFrame(int quality)
	{
		return null;
	}

	public UIAtlas getEnemyDetail()
	{
		return null;
	}

	public UIAtlas getBattleHead()
	{
		return null;
	}

	public void DisposeAll()
	{
	}

	private string GetNextAtlas(string name, string header, string type, int index, int atlasLimit)
	{
		return null;
	}

	public UIAtlas getServantFashionAtlas(string name, int FashionIndex)
	{
		return null;
	}

	public static T GetServantImage<T>(string imageInfo, int fashinIndex, AssetsManager.AssetsType sType = AssetsManager.AssetsType.Temp_1) where T : Object
	{
		return null;
	}

	public static T GetServantImageBg<T>(string imageInfo, int fashinIndex, AssetsManager.AssetsType sType = AssetsManager.AssetsType.Temp_1) where T : Object
	{
		return null;
	}

	public static T GetServantSpecialImageBg<T>(string imageInfo, int fashinIndex, AssetsManager.AssetsType sType = AssetsManager.AssetsType.Temp_1) where T : Object
	{
		return null;
	}

	public static T GetServantIcon<T>(string _spriteName, int fashinIndex) where T : Object
	{
		return null;
	}

	public static T GetWeaponIcon<T>(string _spriteName) where T : Object
	{
		return null;
	}

	public static Texture GetServantBigTextureByImageID(long servantImageID, AssetsManager.AssetsType assetsType)
	{
		return null;
	}

	public static Texture GetWeaponBigTextureByID(long weaponID, AssetsManager.AssetsType assetsType)
	{
		return null;
	}

	public static Texture GetWeaponAwakeBigTextureByID(long weaponID, AssetsManager.AssetsType assetsType)
	{
		return null;
	}
}
