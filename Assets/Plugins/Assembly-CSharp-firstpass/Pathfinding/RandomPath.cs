using System;
using UnityEngine;

namespace Pathfinding
{
	public class RandomPath : ABPath
	{
		public int searchLength;

		public int spread;

		public bool uniform;

		public float aimStrength;

		private PathNode chosenNodeR;

		private PathNode maxGScoreNodeR;

		private int maxGScore;

		public Vector3 aim;

		private int nodesEvaluatedRep;

		private System.Random rnd;

		public RandomPath()
			: base(default(Vector3), default(Vector3), null)
		{
		}

		public RandomPath(Vector3 start, int length, OnPathDelegate callback = null)
			: base(default(Vector3), default(Vector3), null)
		{
		}

		public override void Reset()
		{
		}

		protected override void Recycle()
		{
		}

		public static RandomPath Construct(Vector3 start, int length, OnPathDelegate callback = null)
		{
			return null;
		}

		protected RandomPath Setup(Vector3 start, int length, OnPathDelegate callback)
		{
			return null;
		}

		public override void ReturnPath()
		{
		}

		public override void Prepare()
		{
		}

		public override void Initialize()
		{
		}

		public override void CalculateStep(long targetTick)
		{
		}
	}
}
