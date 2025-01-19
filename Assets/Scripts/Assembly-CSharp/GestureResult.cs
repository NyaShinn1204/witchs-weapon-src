using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GestureResult
{
	public enum GestureTypes
	{
		Unknown = -1,
		Click = 0,
		LongPress = 1,
		Swipe = 2,
		Knead = 3
	}

	public enum SwipeDirectionTypes
	{
		Unknown = -1,
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	public GestureTypes gestureTypes;

	public string name;

	public int clickCount;

	public List<Vector2> trackPoints;

	public List<Collider> clickColls;

	public Vector2 swipeVector;

	public SwipeDirectionTypes swipeDirection;

	public GestureResult(string name, GestureTypes gestureTypes, List<Vector2> trackPoints, List<Collider> clickColls)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
