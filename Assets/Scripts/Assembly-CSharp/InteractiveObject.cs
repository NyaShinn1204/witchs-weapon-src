using UnityEngine;
using WaterBell.ProjX.Level.Event;
using WaterBell.ProjX.Level.Model;

public class InteractiveObject : MonoBehaviour
{
	public enum InteractiveType
	{
		JumpTrigger = 1,
		CameraRotate = 2
	}

	public InteractiveType type;

	public string param;

	private bool PlayerInBattleZone;

	public static GameObject GenerateObjectFromJson(Transform rootNode, InteractiveObjInfo info)
	{
		return null;
	}

	private static void AssignPRS(Transform tf_obj, double[] PRS)
	{
	}

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnPlayerEnterZone(PlayerEnterZoneEvent e)
	{
	}

	private void OnPlayerLeaveZone(MonsterInZoneClearEvent e)
	{
	}

	private void OnJumpFinish()
	{
	}

	private void OnDestory()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
