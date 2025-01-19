using System.Collections.Generic;
using UnityEngine;

public class CameraControllMapChange : MonoBehaviour
{
	private static CameraControllMapChange _runObject;

	private static CameraControllMapChange _runObjectPre;

	private static HashSet<CameraControllMapChange> _runUncare;

	private static Vector3 _runOffsetTrigger;

	public Vector3 cameraRotation;

	public float time;

	public bool isTriggerUncareOnce;

	private float _timeRun;

	public static void CreateByCSV(TypeCsvCameraControlMap sCsv)
	{
	}

	public static void CreateByID(string sID)
	{
	}

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider sTrigger)
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDestory()
	{
	}
}
