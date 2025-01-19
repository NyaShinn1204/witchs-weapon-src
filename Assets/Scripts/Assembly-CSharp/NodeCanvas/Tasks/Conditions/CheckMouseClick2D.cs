using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckMouseClick2D : ConditionTask<Collider2D>
	{
		public MouseClickEvent checkType;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return false;
		}

		public void OnMouseDown()
		{
		}

		public void OnMouseUp()
		{
		}
	}
}
