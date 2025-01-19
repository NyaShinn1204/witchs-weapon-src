using UnityEngine;
using WaterBell.ProjX.Playmode;

public class SelectProperty : MonoBehaviour
{
	public UILabel foundation_0;

	public UILabel foundation_1;

	public UILabel foundation_2;

	public UILabel foundation_3;

	public UILabel foundation_3_1;

	public UILabel foundation_4;

	public UILabel foundation_4_1;

	public UILabel physics_1;

	public UILabel physics_2;

	public UILabel physics_3;

	public UILabel physics_3_1;

	public UILabel physics_4;

	public UILabel physics_5;

	public UILabel magic_1;

	public UILabel magic_2;

	public UILabel magic_3;

	public UILabel magic_3_1;

	public UILabel magic_4;

	public UILabel magic_5;

	public Transform weapon1;

	public Transform bgIcon1;

	public UITexture weaponIcon1;

	public UISprite weaponType1;

	public UISprite weaponRune1;

	public UILabel weaponPhysics1;

	public UILabel weaponMagic1;

	public Transform weapon2;

	public Transform bgIcon2;

	public UITexture weaponIcon2;

	public UISprite weaponType2;

	public UISprite weaponRune2;

	public UILabel weaponPhysics2;

	public UILabel weaponMagic2;

	public Transform weapon3;

	public Transform bgIcon3;

	public UITexture weaponIcon3;

	public UISprite weaponType3;

	public UISprite weaponRune3;

	public UILabel weaponPhysics3;

	public UILabel weaponMagic3;

	public Transform weapon4;

	public Transform bgIcon4;

	public UITexture weaponIcon4;

	public UISprite weaponType4;

	public UISprite weaponRune4;

	public UILabel weaponPhysics4;

	public UILabel weaponMagic4;

	private int HP;

	private int PATK;

	private int MATK;

	private int PDEF;

	private int MDEF;

	private int HV;

	private int DV;

	private int IPDV;

	private int IMDV;

	private int PCV;

	private int MCV;

	private int PCMV;

	private int MCMV;

	public ButtonEx ClosePanelBtn;

	private void Awake()
	{
	}

	public void SetInfo(long[] servants, long[] weapons, long[] rid)
	{
	}

	private void GetValue(long[] servants, long[] weapons, long[] rids, ActivityIDInfo idInfo)
	{
	}

	private void SetWeaponInfo(long rid, long servant, long weapon, Transform bgIcon, UITexture weaponIcon, UISprite weaponType, UISprite weaponRune, UILabel weaponPhysics, UILabel weaponMagic, int index)
	{
	}
}
