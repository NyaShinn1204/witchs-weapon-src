using System.Collections.Generic;
using UnityEngine;

namespace Slate.ActionClips
{
	public class DestroyGameObjects : DirectorActionClip
	{
		public List<GameObject> targetObjects;

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
	}
}
