using System;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class RadiusModifier : MonoModifier
{
	private enum TangentType
	{
		OuterRight = 1,
		InnerRightLeft = 2,
		InnerLeftRight = 4,
		OuterLeft = 8,
		Outer = 9,
		Inner = 6
	}

	public float radius;

	public float detail;

	private float[] radi;

	private float[] a1;

	private float[] a2;

	private bool[] dir;

	public override ModifierData input
	{
		get
		{
			return default(ModifierData);
		}
	}

	public override ModifierData output
	{
		get
		{
			return default(ModifierData);
		}
	}

	private bool CalculateCircleInner(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
	{
		a = default(float);
		sigma = default(float);
		return false;
	}

	private bool CalculateCircleOuter(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
	{
		a = default(float);
		sigma = default(float);
		return false;
	}

	private TangentType CalculateTangentType(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
	{
		return default(TangentType);
	}

	private TangentType CalculateTangentTypeSimple(Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(TangentType);
	}

	private void DrawCircle(Vector3 p1, float rad, Color col, float start = 0f, float end = (float)Math.PI * 2f)
	{
	}

	public override void Apply(Path p, ModifierData source)
	{
	}

	public List<Vector3> Apply(List<Vector3> vs)
	{
		return null;
	}
}
