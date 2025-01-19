using Pathfinding;
using UnityEngine;
using WaterBell.ProjX.Level.Event;

public class ManagerAutoCombat : MonoBehaviour
{
	private static ManagerAutoCombat _instance;

	public int zoneIdx;

	public Path path;

	private bool _isCombatOver;

	private Vector3 targetPosition;

	private float _AutoCombatSkillCD;

	private bool _AutoCombatIsInBattle;

	private bool _AutoCombatIsCamAnimRunning;

	public static ManagerAutoCombat instance
	{
		get
		{
			return null;
		}
	}

	private int zoneIndexNext
	{
		get
		{
			return 0;
		}
	}

	private void Start()
	{
	}

	public void Reset()
	{
	}

	private void OnCombatWin(QuestAccomplishedEvent e)
	{
	}

	private void OnCombatLose(QuestFailedEvent e)
	{
	}

	private void OnPlayerEnterZone(PlayerEnterZoneEvent e)
	{
	}

	private void OnMonsterInZoneClear(MonsterInZoneClearEvent e)
	{
	}

	private void Update()
	{
	}

	private void OnPathSearchSucceedHD(Path p)
	{
	}

	private void eventAutoMove()
	{
	}

	private void eventAutoCombat()
	{
	}
}
