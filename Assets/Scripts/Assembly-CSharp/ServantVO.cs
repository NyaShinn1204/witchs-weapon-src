using System.Collections.Generic;
using Combatmod;

public class ServantVO
{
	public long cardID;

	public long normalAttack1;

	public long normalAttack2;

	public List<long> normalAttackArr;

	public long dashAttack;

	public string controller;

	public long activeSkillId;

	public float normalSpeedRate;

	public string icon;

	public string prefab;

	public string unitNumStr;

	public float weaponPATK;

	public float weaponMATK;

	public WeaponSharpInfoNew sharpInfo;

	public TypeCsvServantWeapon currWeapon;

	public float weaponAttackSpeed;

	public bool needReleaseTarget;

	public float ERT;

	public float ERKT;

	public float ERA;

	public float ERI;

	public int PowerType;

	public float PowerType_arg1;

	public float PowerType_arg2;

	public float PowerType_arg3;

	public int skin;

	public long weaponID
	{
		get
		{
			return 0L;
		}
	}

	public WeaponType weaponType
	{
		get
		{
			return default(WeaponType);
		}
	}

	public string weaponBuildDir
	{
		get
		{
			return null;
		}
	}

	public string builderPrefabURL
	{
		get
		{
			return null;
		}
	}

	public ServantVO(long ID, long activeSkillId)
	{
	}

	public ServantVO(long ID, long activeSkillId, Combatmod.WeaponSharpInfo wpSharpInfo)
	{
	}
}
