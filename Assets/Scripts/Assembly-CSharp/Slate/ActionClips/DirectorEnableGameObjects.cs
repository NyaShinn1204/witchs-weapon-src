using System.Collections.Generic;
using UnityEngine;

namespace Slate.ActionClips
{
	public class DirectorEnableGameObjects : DirectorActionClip
	{
		public List<GameObject> targetObjects;

		private Dictionary<GameObject, bool> states;

		public override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
