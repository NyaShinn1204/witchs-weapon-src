using System.Collections.Generic;
using UnityEngine;

public class MonsterTable : ScriptableObject
{
	public List<string> midList;

	public List<MonsterStatVO> monsterList;

	public MonsterTable(List<string> mList1, List<MonsterStatVO> mList2)
	{
	}

	public MonsterTable()
	{
	}

	public void Add(string id, MonsterStatVO ms)
	{
	}
}
