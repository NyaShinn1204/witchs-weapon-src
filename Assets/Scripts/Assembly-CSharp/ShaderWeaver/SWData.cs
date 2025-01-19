using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class SWData
	{
		public SWShaderQueue shaderQueue;

		public SWRenderType rt;

		public int shaderQueueOffset;

		public SWShaderType shaderType;

		public SWSpriteLightType spriteLightType;

		public SWShaderModel shaderModel;

		public SWShaderBlend shaderBlend;

		public bool excludeRoot;

		public int version;

		public float pixelPerUnit;

		public Rect spriteRect;

		public string title;

		public string materialGUID;

		public List<string> masksGUID;

		public List<SWParam> paramList;

		public List<SWDataNode> nodes;

		public float clipValue;

		public string fallback;

		public string sn;

		public bool pum;

		public float ps;

		public float psm;

		public SWDataNode FindNode(string id)
		{
			return null;
		}

		public bool ContainParam(SWParam param)
		{
			return false;
		}
	}
}
