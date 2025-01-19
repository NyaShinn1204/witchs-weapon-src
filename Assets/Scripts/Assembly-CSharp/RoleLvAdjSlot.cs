using UnityEngine;

public class RoleLvAdjSlot : MonoBehaviour
{
	private int dirtyCounter;

	private static readonly int roleLvMin;

	private static readonly int roleLvMax;

	private static readonly Color origColor;

	private static readonly Color dirtyColor;

	private int _roleLv;

	private int _roleLvOrig;

	public UILabel roleLvValLabel;

	public UIButton roleLvAddBtn;

	public UIButton roleLvSubBtn;

	public bool isDirty
	{
		get
		{
			return false;
		}
	}

	private int roleLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void show(int lv)
	{
	}

	public int GetRoleLv()
	{
		return 0;
	}

	private void reset()
	{
	}

	private void roleLvAdd()
	{
	}

	private void roleLvSub()
	{
	}
}
