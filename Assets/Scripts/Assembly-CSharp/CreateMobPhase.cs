using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using unit;

public class CreateMobPhase : SkillPhase
{
	public static Dictionary<string, int> createMobDic;

	private static bool isGetAll;

	public CreateMobPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public static void StatAllMobCount()
	{
	}

	public static void StatMobCount(string id, int count)
	{
	}

	public static void ClearMobCount()
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	public static MonsterEntity CreateMob(string uuid, long mobid, Vector3 pos, Entity en, int layer = 0, int max = 1)
	{
		return null;
	}

	private static Vector3 GetUnBlockedPosition(Vector3 pos, MonsterVO vo, Entity en, Entity master)
	{
		return default(Vector3);
	}

	public static MonsterEntity Call(MonsterVO vo, Entity realMaster, string prefabURI, Vector3 position, Transform foceTo = null, int appearState = 21)
	{
		return null;
	}

	private static Entity FindRealMaster(Entity master)
	{
		return null;
	}
}
