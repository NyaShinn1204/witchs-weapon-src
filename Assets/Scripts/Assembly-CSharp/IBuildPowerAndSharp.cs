public interface IBuildPowerAndSharp
{
	float GetWeaponSharp(long weaponid);

	float GetWeaponSharpMax(long weaponid);

	float GetServantPower(long servantID);

	float GetServantPowerMax(long servantID);

	void ResetPowerAndSharp();

	int IsCanReleaseSkill(long servantID);

	void ReleaseSkill(long servantID);

	int IsCanChangeWeapon(long weaponID);

	void ChangeWeapon(long servantID);

	void ChangeWeaponSharp(long weaponID, float val);

	void ChangeServantPower(long servantID, float val);

	void ModifyServantPower(int type, float value, long servantID);

	int GetCurrentWeaponEnterSharp();

	void ModifyWeaponSharp(int type, int value, long weaponID, int amendtype, int valuetype);

	int GetCurrentWeaponSharpMax();

	int GetCurrentWeaponSharp();

	void ModifyWeaponLock(int type, long weaponID, int state, float time);
}
