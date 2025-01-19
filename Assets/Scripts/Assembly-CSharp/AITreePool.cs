using System.Collections.Generic;
using UnityEngine;

public class AITreePool
{
	public enum AITreeType
	{
		Null = -1,
		moveToTarget = 1,
		moveToPosition = 2,
		moveToTargetNear = 3,
		moveToRandom = 4,
		releaseSkill = 5
	}

	public class AITreePoolData
	{
		private Dictionary<AITreeType, FunctionBool> _listener;

		private AITreeType _type;

		public AITreeType type
		{
			get
			{
				return default(AITreeType);
			}
		}

		public void addListener(AITreeType sType, FunctionBool sListener)
		{
		}

		public void finished(AITreeType sType, bool sIsSucceed = true)
		{
		}

		public bool done(AITreeType sType)
		{
			return false;
		}
	}

	private static AITreePool _instance;

	private Dictionary<GameObject, AITreePoolData> _data;

	public static AITreePool instance
	{
		get
		{
			return null;
		}
	}

	public AITreePoolData Item
	{
		get
		{
			return null;
		}
	}

	public void clear()
	{
	}
}
