using System.Collections.Generic;
using UnityEngine;

public class CameraGyro : MonoBehaviour
{
	private static List<CameraGyro> _instance;

	private bool _isHasGyro;

	private bool _isEnableGyro;

	private Quaternion? _baseGyro;

	private Quaternion _baseRotation;

	private bool _isEnable;

	[SerializeField]
	private float _minX;

	[SerializeField]
	private float _maxX;

	[SerializeField]
	private float _minY;

	[SerializeField]
	private float _maxY;

	public static void Stop()
	{
	}

	public static void Show()
	{
	}

	public static void Reset()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ResetGyro()
	{
	}

	private void OnDestroy()
	{
	}
}
