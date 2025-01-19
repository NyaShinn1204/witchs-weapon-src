using System.Runtime.InteropServices;
using UnityEngine;

public class DamageNumberBase : MonoBehaviour
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	public struct target
	{
		public float alpha;

		public float scale;

		public float y;

		public target(float _y, float _scale, float _alpha)
		{
			alpha = 0f;
			scale = 0f;
			y = 0f;
		}
	}

	[StructLayout(LayoutKind.Sequential, Size = 20)]
	public struct rule
	{
		public int mode;

		public int frame;

		public target target;

		public rule(int _mode, int _frame, target _target)
		{
			mode = 0;
			frame = 0;
			target = default(target);
		}
	}

	public const int CHAR_WIDTH = 24;

	public const int CHAR_HEIGHT = 32;

	public const int CHAR_WIDTH_CRIT = 32;

	protected BetterList<HalfColorUISprite> imgList;

	protected int step;

	protected int mode;

	protected int subStepTotalFrame;

	protected int subStepFrame;

	protected target subStepTarget;

	public const int MODE_CHOOSE = 0;

	public const int MODE_WAIT = 1;

	public const int MODE_BALANCE = 2;

	public const int MODE_BALANCE_END = 3;

	public const int MODE_MOVE = 4;

	public const int COLOR_RED = 0;

	public const int COLOR_YELLOW = 1;

	public rule[] rules;

	protected int frame;

	public bool isBalance
	{
		get
		{
			return false;
		}
	}

	public void init(string str, int color, int width)
	{
	}

	private void Update()
	{
	}

	public void choose()
	{
	}

	public void copyVar(HalfColorUISprite imgTarget, HalfColorUISprite imageSrc)
	{
	}

	public void applySetting(target target, HalfColorUISprite con, int totalFrame, int currFrame)
	{
	}

	public void balance()
	{
	}

	public void balance_end()
	{
	}

	public void wait()
	{
	}

	public void move()
	{
	}

	public HalfColorUISprite addChar(string str, int color)
	{
		return null;
	}

	public static DamageNumberBase getNormalNumber(string str, int color, Vector3 pos, GameObject parent)
	{
		return null;
	}

	public static DamageNumberBase getCritNumber(string str, int color, Vector3 pos, GameObject parent)
	{
		return null;
	}
}
