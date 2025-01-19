using UnityEngine;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Playmode;

public class NextZoneArrow : MonoBehaviour
{
	public static NextZoneArrow current;

	public int zoneIdx;

	private IPlayMode mode;

	private int areaIdx;

	private Transform heroTF;

	private bool isQuestOver;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void AddListener()
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

	private float GetWorldAngle(float disX, float disY)
	{
		return 0f;
	}
}
