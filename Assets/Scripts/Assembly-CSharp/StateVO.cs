public class StateVO
{
	public const int TYPE_ADD = 1;

	public const int TYPE_SUB = 2;

	public int isStun;

	public bool isStunHasShift;

	public int isSilence;

	public int isNoMove;

	public int isBuffNagtiveImmue;

	public int isPhysicDamageImmue;

	public int isMagicDamageImmue;

	public int isHealImmue;

	public int isStunImmue;

	public int isSilenceImmue;

	public int isNoMoveImmue;

	public int isPassiveShiftImmue;

	public int isDeathImmue;

	public int isNoDeath;

	public int isAllImmue;

	public int isNotStunPassiveShiftImmue;

	public int isCannotChangeWeapon;

	public int isCannotChangeWeaponSharp;

	public int isFearImme;

	public bool isMoving;

	public void ChangeStateTag(int tag, int type)
	{
	}
}
