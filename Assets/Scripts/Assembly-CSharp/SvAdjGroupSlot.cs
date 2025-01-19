using UnityEngine;
using WaterBell.LevelDesign;

public class SvAdjGroupSlot : MonoBehaviour
{
	public ServantAblitySetting setting;

	private int dirtyCounter;

	private static readonly int starMin;

	private static readonly int starMax;

	private static readonly int rankMin;

	private static readonly int rankMax;

	private static readonly int lvMin;

	private static readonly int lvMax;

	private static readonly int eqMin;

	private static readonly int eqMax;

	private static readonly int starPointMin;

	private static readonly int starPointMax;

	private static readonly int activeSkillMin;

	private static readonly int activeSkillMax;

	private static readonly int passivSkillMin;

	private static readonly int passiveSkillMax;

	private static readonly int weaponLvMin;

	private static readonly int weaponLvMax;

	private static readonly int weaponPromoteLvMin;

	private static readonly int weaponPromoteLvMax;

	private static readonly int weaponSkillPromoteLvMin;

	private static readonly int weaponSkillPromoteLvMax;

	private static readonly Color origColor;

	private static readonly Color dirtyColor;

	private int _star;

	private int _rank;

	private int _lv;

	private int _eq;

	private int _activeskill;

	private int _starpoint;

	private int _passiveskill;

	private int _weaponLv;

	private int _weaponPromoteLv;

	private int _weaponSkillPromoteLv;

	private int _starOrig;

	private int _rankOrig;

	private int _lvOrig;

	private int _eqOrig;

	private int _activeSkillOrig;

	private int _startPointOrig;

	private int _passiveSkillOrig;

	private int _weaponLvOrig;

	private int _weaponPromoteLvOrig;

	private int _weaponSkillPromoteLvOrig;

	public UILabel starValLabel;

	public UILabel rankValLabel;

	public UILabel lvValLabel;

	public UILabel eqValLabel;

	public UILabel activeSkillValLabel;

	public UILabel starPointValLabel;

	public UILabel passiveSkillValLabel;

	public UILabel wpValLabel;

	public UILabel wpmValLabel;

	public UILabel wspmValLabel;

	public UIButton starAddBtn;

	public UIButton starSubBtn;

	public UIButton rankAddBtn;

	public UIButton rankSubBtn;

	public UIButton lvAddBtn;

	public UIButton lvSubBtn;

	public UIButton enAddBtn;

	public UIButton enSubBtn;

	public UIButton activeSkillAddBtn;

	public UIButton activeSkillSubBtn;

	public UIButton starPointAddBtn;

	public UIButton starPointSubBtn;

	public UIButton passiveSkillAddBtn;

	public UIButton passiveSkillSubBtn;

	public UIButton wpAddBtn;

	public UIButton wpSubBtn;

	public UIButton wpmAddBtn;

	public UIButton wpmSubBtn;

	public UIButton wspmAddBtn;

	public UIButton wspmSubBtn;

	public bool isDirty
	{
		get
		{
			return false;
		}
	}

	public int star
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int rank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int lv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int eq
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int activeSkillLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int startPoint
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int passiveSkill
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int weaponLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int wpPromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int wpSkillPromoteLv
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

	public void show(int s, int r, int lv, int eq = 0)
	{
	}

	public void show(int s, int r, int lv, int starPoint, int activeSkillLv, int passiveSkillLv, int weaponLv, int weaponPromoteLv, int weaponSkillPromoteLv)
	{
	}

	private void Reset()
	{
	}

	public string GetSvStateStr()
	{
		return null;
	}

	private void starAdd()
	{
	}

	private void starSub()
	{
	}

	private void rankAdd()
	{
	}

	private void rankSub()
	{
	}

	private void lvAdd()
	{
	}

	private void lvSub()
	{
	}

	private void siAdd()
	{
	}

	private void siSub()
	{
	}

	private void slAdd()
	{
	}

	private void slSub()
	{
	}

	private void ps1Add()
	{
	}

	private void ps1Sub()
	{
	}

	private void wpAdd()
	{
	}

	private void wpSub()
	{
	}

	private void wpmAdd()
	{
	}

	private void wpmSub()
	{
	}

	private void wspmAdd()
	{
	}

	private void wspmSub()
	{
	}
}
