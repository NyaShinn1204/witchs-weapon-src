using System.Collections.Generic;

public class BuildPowerAndSharp : IBuildPowerAndSharp
{
	public const int WEAPON_CURRNET = 1;

	public const int WEAPON_NOT_CURRNET = 2;

	public const int WEAPON_SPECIFIL = 3;

	public const int WEAPON_LOWSHARP = 4;

	public const int SERVANT_CURRNET = 1;

	public const int SERVANT_NOT_CURRNET = 2;

	public const int SERVANT_ALL = 3;

	public const int SERVANT_SPECIFIL = 4;

	public static readonly int POWER_MAX;

	private Dictionary<long, PowerData> powerData;

	private Dictionary<long, SharpData> sharpData;

	private Dictionary<long, LockData> lockData;

	private bool isRegisted;

	private long currWeaponID;

	private float currWeaponEnterSharp;

	public bool isStarted;

	private float changeWepaonCD;

	private bool isPaused;

	private HeroEntity hero;

	private PropertiesVO heroprop;

	private bool isLockPower;

	private bool isLockSharp;

	private float lastshap;

	private float lastshap2;

	private LabelTips labeltips;

	public float guildAllPowerRate;

	public float guildServantPowerRate;

	public long guildPowerServantID;

	public float guildSharpRate;

	public long guildSharpServantID;

	public void OnStart()
	{
	}

	public float GetServantPowerMax(long servantID)
	{
		return 0f;
	}

	public void ResetPowerAndSharp()
	{
	}

	private void ResetPower()
	{
	}

	private void ResetPower4Expedition()
	{
	}

	private void ResetSharp()
	{
	}

	private void ResetLock()
	{
	}

	public void ResetSharpToMax(long servantID)
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateCD()
	{
	}

	private void Updatelocktime()
	{
	}

	private float GetGuildSharpLimitRate(long servantID)
	{
		return 0f;
	}

	private void UpdateSharp()
	{
	}

	private void CalulateERTAndERKTPower()
	{
	}

	private void EnegyRegenByHit(BaseEvent evt)
	{
	}

	private void EnegyRegenByDamaged(BaseEvent evt)
	{
	}

	private void AttackChangeSharp(BaseEvent evt)
	{
	}

	private void HitChangeSharp(BaseEvent evt)
	{
	}

	private void CheckPowerCondition(PowerData data)
	{
	}

	public float GetWeaponSharp(long weaponid)
	{
		return 0f;
	}

	public float GetWeaponSharpMax(long weaponid)
	{
		return 0f;
	}

	public float GetServantPower(long servantID)
	{
		return 0f;
	}

	public int IsCanReleaseSkill(long servantID)
	{
		return 0;
	}

	public void ReleaseSkill(long servantID)
	{
	}

	public int IsCanChangeWeapon(long weaponID)
	{
		return 0;
	}

	public int IsLockWeapon(long weaponID)
	{
		return 0;
	}

	public float IsLockWeaponTime(long weaponID)
	{
		return 0f;
	}

	public float IsLockWeaponTimeCurrent(long weaponID)
	{
		return 0f;
	}

	public void ChangeWeapon(long svCardID)
	{
	}

	public void TakeOffWeapon(ServantVO servantVO)
	{
	}

	public void LasyWithWeapon(ServantVO servantVO)
	{
	}

	private void FixWeaponDashDistance(long dashSkillID)
	{
	}

	private void SetInUse(long weaponID)
	{
	}

	public void ChangeWeaponSharp(long weaponID, float val)
	{
	}

	public void ChangeServantPower(long servantID, float val)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public int GetCurrentWeaponSharp()
	{
		return 0;
	}

	public int GetCurrentWeaponSharpMax()
	{
		return 0;
	}

	public void ModifyWeaponSharp(int type, int value, long weaponID, int amendtype, int valuetype)
	{
	}

	public int GetCurrentWeaponEnterSharp()
	{
		return 0;
	}

	public void ModifyServantPower(int type, float value, long servantID)
	{
	}

	public void ModifyWeaponLock(int type, long weaponID, int state, float time)
	{
	}

	public void LockPower()
	{
	}

	public void UnLockPower()
	{
	}

	public void LockSharp()
	{
	}

	public void UnLockSharp()
	{
	}

	public void ChangeSharpvalue(Dictionary<long, SharpData> _sharpdata)
	{
	}

	public void RecoverSharpvalue(Dictionary<long, SharpData> _sharpdata)
	{
	}

	public Dictionary<long, SharpData> GetSharpvalue()
	{
		return null;
	}
}
