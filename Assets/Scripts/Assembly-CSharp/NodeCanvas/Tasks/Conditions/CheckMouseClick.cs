using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckMouseClick : ConditionTask<Collider>
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
