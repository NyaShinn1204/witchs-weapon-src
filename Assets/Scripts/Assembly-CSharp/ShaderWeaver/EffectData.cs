using System;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class EffectData
	{
		public Vector2 t_startMove;

		public float r_angle;

		public Vector2 s_scale;

		public Vector2 t_speed;

		public float r_speed;

		public Vector2 s_speed;

		public string t_Param;

		public string r_Param;

		public string s_Param;

		public bool pop_final;

		public float pop_min;

		public float pop_max;

		public float pop_startValue;

		public float pop_speed;

		public string pop_Param;

		public SWChannel pop_channel;

		public bool useLoop;

		public SWLoopMode loopX;

		public float gapX;

		public SWLoopMode loopY;

		public float gapY;

		public bool animationSheetUse;

		public int animationSheetCountX;

		public int animationSheetCountY;

		public bool animationSheetLoop;

		public bool animationSheetSingleRow;

		public int animationSheetSingleRowIndex;

		public int animationSheetStartFrame;

		public string animationSheetFrameFactor;
	}
}
