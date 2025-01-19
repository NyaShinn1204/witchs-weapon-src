using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class SWDataNode
	{
		public bool useNormal;

		public string id;

		public string name;

		public int depth;

		public SWNodeType type;

		public int parentPortNumber;

		public List<string> parent;

		public List<int> parentPort;

		public int childPortNumber;

		public List<string> children;

		public List<int> childrenPort;

		public string textureExGUID;

		public string textureGUID;

		public bool useGray;

		public bool useCustomTexture;

		public string textureGUIDGray;

		public string spriteGUID;

		public string spriteName;

		public Rect rect;

		public EffectData effectData;

		public EffectDataColor effectDataColor;

		public EffectDataUV effectDataUV;

		public SWChannel maskChannel;

		public List<SWDataType> outputType;

		public List<SWDataType> inputType;

		public bool dirty;

		public Vector2 remap;

		public SWLayerMaskString layerMask;

		public float blurX;

		public float blurY;

		public string blurXParam;

		public string blurYParam;

		public float retro;

		public string retroParam;

		public List<SWGradient> gradients;

		public float tst;

		public string tstParam;

		public float tstRad;

		public string tstRadParam;

		public Vector2 tstPos;

		public float pinch;

		public string pinchParam;

		public float fishEye;

		public string fishEyeParam;

		public CodeParamType codeType;

		public string code;

		public List<SWCodeParamUse> codeParams;

		public SWCoordMode coordMode;

		public SWTexResolution reso;

		public string iName
		{
			get
			{
				return null;
			}
		}

		public static List<int> resoList
		{
			get
			{
				return null;
			}
		}

		public int resolution
		{
			get
			{
				return 0;
			}
		}

		public SWDataNode(SWNodeType _type)
		{
		}

		public SWCodeParamUse GetCodeParamUse(string name)
		{
			return null;
		}

		public SWDataType GetCodeType()
		{
			return default(SWDataType);
		}

		public void AssingNewID()
		{
		}

		public string ChildOfPort(int p)
		{
			return null;
		}

		public string ParentOfPort(int p)
		{
			return null;
		}
	}
}
