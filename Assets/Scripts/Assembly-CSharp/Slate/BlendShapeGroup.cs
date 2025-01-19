using System;
using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class BlendShapeGroup
	{
		[SerializeField]
		private string _UID;

		[SerializeField]
		private string _name;

		[SerializeField]
		private float _weight;

		[SerializeField]
		private List<BlendShape> _blendShapes;

		public string UID
		{
			get
			{
				return null;
			}
			private set
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

		public List<BlendShape> blendShapes
		{
			get
			{
				return null;
			}
		}

		private void SetBlendWeights()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
