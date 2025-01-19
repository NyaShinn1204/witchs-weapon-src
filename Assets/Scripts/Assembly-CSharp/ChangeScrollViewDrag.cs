using System.Collections.Generic;
using UnityEngine;

public class ChangeScrollViewDrag : MonoBehaviour
{
	public enum state
	{
		h = 0,
		v = 1
	}

	public int Num;

	public state m_state;

	private float max_value;

	private float item_value;

	private float space_between;

	public Transform item;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetPostion<T>(List<T> list)
	{
	}

	private void GetSize()
	{
	}
}
