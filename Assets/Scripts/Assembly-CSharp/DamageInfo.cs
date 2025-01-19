using System;
using UnityEngine;

[Serializable]
public class DamageInfo
{
	public Transform target;

	public Transform player;

	public Transform attacker;

	public bool isDamage;

	public long physicValue;

	public long magicValue;

	public long solidValue;

	public long healValue;

	public bool isCombin;

	public bool isHit;

	public bool isAbsorb;

	public bool isCritical;

	public bool isImmue;

	public bool isDodge;

	public bool isBackhit;

	public bool isSteal;

	public bool isResist;

	public bool isStun;

	public bool isSlience;

	public bool isNomove;

	public bool isLinklife;

	public DamageInfo()
	{
	}

	public DamageInfo(Transform target, Transform player, Transform attacker, bool isDamage, bool isHit, bool isAbsorb, bool isCritical, bool isImmue, bool isDodge, long physicValue, long magicValue, long solidValue, long healValue, bool isCombin)
	{
	}

	public DamageInfo GetClone()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
