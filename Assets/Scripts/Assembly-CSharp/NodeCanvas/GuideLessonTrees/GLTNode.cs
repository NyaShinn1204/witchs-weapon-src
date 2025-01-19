using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.GuideLessonTrees
{
	public abstract class GLTNode : Node
	{
		public override string name
		{
			get
			{
				return null;
			}
		}

		public override int maxInConnections
		{
			get
			{
				return 0;
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public sealed override Type outConnectionType
		{
			get
			{
				return null;
			}
		}

		public sealed override bool allowAsPrime
		{
			get
			{
				return false;
			}
		}

		public sealed override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		public GuideLessonTree GLTree
		{
			get
			{
				return null;
			}
		}

		public T AddChild<T>(Vector2 pos) where T : GLTNode
		{
			return null;
		}
	}
}
