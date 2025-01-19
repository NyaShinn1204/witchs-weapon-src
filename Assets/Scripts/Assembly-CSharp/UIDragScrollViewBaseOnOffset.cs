using UnityEngine;

public class UIDragScrollViewBaseOnOffset : MonoBehaviour
{
	public ScrollViewBaseOnOffset scrollView;

	[HideInInspector]
	[SerializeField]
	private ScrollViewBaseOnOffset draggablePanel;

	private Transform mTrans;

	private ScrollViewBaseOnOffset mScroll;

	private bool mAutoFind;

	private bool mStarted;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void FindScrollView()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}
