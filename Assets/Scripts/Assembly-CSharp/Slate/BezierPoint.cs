using System;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class BezierPoint
	{
		public enum HandleStyle
		{
			Connected = 0,
			Broken = 1,
			None = 2
		}

		[SerializeField]
		private BezierPath _path;

		[SerializeField]
		public Vector3 _position;

		[SerializeField]
		private Vector3 _handle1;

		[SerializeField]
		private Vector3 _handle2;

		[SerializeField]
		private HandleStyle _handleStyle;

		public HandleStyle handleStyle
		{
			get
			{
				return default(HandleStyle);
			}
			set
			{
			}
		}

		public BezierPath path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 handle1
		{
			get
			{
				return default(Vector3);
			}
			private set
			{
			}
		}

		public Vector3 globalHandle1
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 handle2
		{
			get
			{
				return default(Vector3);
			}
			private set
			{
			}
		}

		public Vector3 globalHandle2
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public BezierPoint(BezierPath path, Vector3 position)
		{
		}
	}
}
