using System;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public struct PositionParameter : ITransformableHelperParameter
	{
		[SerializeField]
		private Transform _transform;

		[SerializeField]
		private Vector3 _vector;

		[SerializeField]
		private TransformSpace _space;

		public bool useAnimation
		{
			get
			{
				return false;
			}
		}

		public TransformSpace space
		{
			get
			{
				return default(TransformSpace);
			}
			private set
			{
			}
		}

		public Transform transform
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Vector3 value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
