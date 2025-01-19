using System.Collections.Generic;
using UnityEngine;

public class Target
{
	public const int TYPE_ENTITY = 2;

	public const int TYPE_POINT = 1;

	public int type;

	public List<Entity> entities;

	public List<Vector3> points;

	public Entity GetSingleTarget()
	{
		return null;
	}

	public Vector3 GetSinglePoint()
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}

	public void Overlay(Target other)
	{
	}

	public void Except(Target other)
	{
	}

	public Vector3 GetTargetCenterPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetTargetFeetPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetTargetRotate()
	{
		return default(Vector3);
	}

	public bool IsEmpty()
	{
		return false;
	}

	public void Clear()
	{
	}

	public List<Entity> GetEntities()
	{
		return null;
	}

	public int GetCount()
	{
		return 0;
	}
}
