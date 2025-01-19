using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MotionTPL : BaseTPL
{
	public List<MotionTPL> children;

	private string tagName;

	private float life;

	public int faceTo;

	public float faceToSpeed;

	public int faceToStart;

	public Vector3 axis;

	public float angle;

	public float rotSpeed;

	public string TagName
	{
		get
		{
			return null;
		}
	}

	public float Life
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public MotionTPL()
	{
	}

	public MotionTPL(XmlElement node, string tagName)
	{
	}

	public MotionTPL(string tagName)
	{
	}

	protected void Init(string tagName)
	{
	}

	public virtual void AddChild(MotionTPL child)
	{
	}
}
