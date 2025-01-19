using System;
using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class UIRawResData : UIDataBase
	{
		private static readonly HashSet<GlobalEnum.ResType> SimpleResTypeSet;

		public static string[] QualitySpriteNameArr1;

		public static string[] QualitySpriteNameArr2;

		public static string[] WeaponQualitySpriteName;

		public static string[] WeaponTypeSpriteName;

		public static readonly string PckSelectedIconAtlasName;

		public static readonly string PckSelectedIconAtlasPath;

		public static readonly string CurrencyIconAtlasName;

		public static readonly string CurrencyIconAtlasPath;

		public static readonly string QualityAndIconFrameAtlasName;

		public static readonly string QualityAndIconFrameAtlasPath;

		public static readonly string WeaponTypeAtlasName;

		public static readonly string WeaponTypeAtlasNamePath;

		public static readonly string WeaponSuperScirptAtlasName;

		public static readonly string WeaponSuperScirptAtlasPath;

		public static readonly string IconFrameSpriteName_shard;

		public static readonly string IconFrameSpriteName_whole;

		public static readonly string IconFrameSpriteName_Sv;

		public static readonly string IconFrameSpriteNameItem;

		public static readonly string WeaponFrameSpriteName;

		public static readonly string SelectedIconSpriteName_SvAndWp;

		public static readonly string SelectedIconSpriteName_shard;

		public static readonly string SelectedIconSpriteName_whole;

		public static readonly string superScriptFashion;

		public static readonly string superScriptCharacterGesture;

		public static readonly string superScriptServantStandPaint;

		public static readonly string superScriptServantDisplayGesture;

		public static readonly string superScriptHead;

		public long OriginID;

		public GlobalEnum.ResType OriginType;

		public long OriginValue;

		public int OriginNum;

		public long rawID;

		public GlobalEnum.ResType rawType;

		public long rawValue;

		public int rawNum;

		public long goodsID;

		public string weaponRare;

		public GlobalEnum.ResItemType rawItemType;

		public GlobalEnum.ResQuality rawQuality;

		public GlobalEnum.ResConsumableItemType rawConsumableItemType;

		public string rawName;

		public string typeName;

		public int sortID;

		public string rawSuperScriptSpriteName;

		public string rawIconSpriteName;

		public string rawIconFrameSpriteName;

		public string rawSelectedIconSpriteName;

		protected bool isShard;

		protected long relatedID;

		public UIAtlas rawSuperScriptAtlas
		{
			get
			{
				return null;
			}
		}

		public UIAtlas rawIconAtlas
		{
			get
			{
				return null;
			}
		}

		public string rawIconFrameSpriteCloseName
		{
			get
			{
				return null;
			}
		}

		public UIAtlas rawIconFrameAtals
		{
			get
			{
				return null;
			}
		}

		public virtual UIAtlas rawSelectedIconAtlas
		{
			get
			{
				return null;
			}
		}

		public UIRawResData()
		{
		}

		public UIRawResData(GlobalEnum.ResType rType)
		{
		}

		public UIRawResData(long resID, GlobalEnum.ResType rType)
		{
		}

		public UIRawResData(long resID)
		{
		}

		public UIRawResData(long resID, GlobalEnum.ResType resType, long value, int num)
		{
		}

		public UIRawResData(ObservableSingleRune rune)
		{
		}

		protected void Init(long resID, GlobalEnum.ResType rType, long value, int num, ObservableSingleRune rune = null)
		{
		}

		protected void InitCoreAttrs()
		{
		}

		protected virtual void InitOtherAttrs()
		{
		}

		private string GetQualitySpriteName()
		{
			return null;
		}

		private string GetWeaponTypeSpriteName(int weaponType, bool isAwake)
		{
			return null;
		}

		private string GetWeaponIconFrameSpriteName(int rare)
		{
			return null;
		}
	}
}
