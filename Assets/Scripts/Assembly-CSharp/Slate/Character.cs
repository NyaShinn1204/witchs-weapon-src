using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public class Character : MonoBehaviour
	{
		[SerializeField]
		private List<BlendShapeGroup> _expressions;

		[SerializeField]
		private Transform _neckTransform;

		[SerializeField]
		private Transform _headTransform;

		[SerializeField]
		private Vector3 _upVector;

		[SerializeField]
		private Vector3 _rotationOffset;

		public Transform neck
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform head
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 upVector
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 rotationOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public List<BlendShapeGroup> expressions
		{
			get
			{
				return null;
			}
		}

		public BlendShapeGroup FindExpressionByName(string name)
		{
			return null;
		}

		public BlendShapeGroup FindExpressionByUID(string UID)
		{
			return null;
		}

		public void SetExpressionWeightByName(string name, float weight)
		{
		}

		public void SetExpressionWeightByUID(string UID, float weight)
		{
		}

		public void ResetExpressions()
		{
		}
	}
}
