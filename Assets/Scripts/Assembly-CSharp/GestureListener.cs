using System;
using System.Collections.Generic;
using UnityEngine;

public class GestureListener : MonoBehaviour
{
	private const float CHECK_DELAY = 0.6f;

	private const float SAMPLE_DISTANCE = 10f;

	private const float SWIPE_DISTANCE_THRESHOLD = 50f;

	private const float KNEAD_DISTANCE_MAX = 300f;

	private const float KNEAD_DISTANCE_MIN = 12f;

	private const float LONG_PRESS_THRESHOLD = 0.8f;

	private const float CLICK_DISTANCE_TOLERANCE = 8f;

	public Camera cam;

	public LayerMask eventMask;

	public string eventTag;

	private List<Vector2> trackPoints;

	private List<Collider> clickColls;

	private Vector2 prevPos;

	private float startTime;

	private bool isCheck;

	private GestureResult result;

	public Action<Vector2> OnBegan;

	public Action<Vector2> OnMoved;

	public Action<GestureResult> OnEnded;

	public Action<GestureResult> OnGetGesture;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void CheckGesture()
	{
	}

	public Collider GetCollByPosition(Vector2 mousePos)
	{
		return null;
	}
}
