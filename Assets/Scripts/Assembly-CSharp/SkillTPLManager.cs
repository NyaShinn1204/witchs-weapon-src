using System.Collections.Generic;
using UnityEngine;

public class SkillTPLManager : MonoBehaviour
{
	private new static string name;

	private static GameObject initObj;

	private static SkillTPLManager instance;

	public Dictionary<long, SkillTPL> collection;

	private List<Entity> dicBuffer;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	public static SkillTPLManager GetInstance()
	{
		return null;
	}

	public void AddSkillTPL(SkillTPL tpl)
	{
	}

	public SkillTPL GetSkillTPL(long ID)
	{
		return null;
	}

	private void SetAllCDTimes()
	{
	}
}
