using System.Collections.Generic;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[ExecuteInEditMode]
	public class GlobalBlackboard : Blackboard
	{
		public static List<GlobalBlackboard> allGlobals;

		public bool dontDestroy;

		public new string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GlobalBlackboard Create()
		{
			return null;
		}

		public static GlobalBlackboard Find(string name)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsUnique()
		{
			return false;
		}
	}
}
