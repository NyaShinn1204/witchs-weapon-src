using DG.Tweening;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
	public bool IsFaghting;

	public Animator feixingqi;

	public Animator zuozhan;

	private bool isRotating;

	public float rotateSpeed;

	private float minY;

	private float maxY;

	private float rotatinY;

	private float timer;

	private float offsetTime;

	private float lastTouch;

	private float currentTouch;

	private float drageOffset;

	private void Start()
	{
	}

	private void NewDrag()
	{
	}

	public float SetRotationLimit(float _value)
	{
		return 0f;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	public void MainSceneStart()
	{
	}

	public void OpenExploreAnim()
	{
	}

	public void CloseExploreAnim()
	{
	}

	public Tweener HeroRotateAnim()
	{
		return null;
	}

	public Tweener HeroPositionAnim()
	{
		return null;
	}

	public void HeroComeBackMain()
	{
	}

	public void OpenKanban()
	{
	}

	public void CloseKanban()
	{
	}

	public void SetAmount(float per)
	{
	}

	public void ToRotation(float sEulerX = 0f, float sEulerY = 20f, float sEulerZ = 0f)
	{
	}
}
