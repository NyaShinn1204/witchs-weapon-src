using System;
using UnityEngine;

namespace Pathfinding
{
	public class FleePath : RandomPath
	{
		[Obsolete]
		public FleePath(Vector3 start, Vector3 avoid, int length, OnPathDelegate callbackDelegate = null)
		{
		}

		public FleePath()
		{
		}

		public static FleePath Construct(Vector3 start, Vector3 avoid, int searchLength, OnPathDelegate callback = null)
		{
			return null;
		}

		protected void Setup(Vector3 start, Vector3 avoid, int searchLength, OnPathDelegate callback)
		{
		}

		protected override void Recycle()
		{
		}
	}
}
