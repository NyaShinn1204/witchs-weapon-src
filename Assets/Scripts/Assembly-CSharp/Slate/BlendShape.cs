using System;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class BlendShape
	{
		[SerializeField]
		private SkinnedMeshRenderer _skin;

		[SerializeField]
		private string _name;

		[SerializeField]
		private float _weight;

		public SkinnedMeshRenderer skin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void SetRealWeight(float modWeight)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
