using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckMouse : ConditionTask<Collider>
	{
		public MouseInteractionTypes checkType;

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

		public void OnMouseEnter()
		{
		}

		public void OnMouseExit()
		{
		}

		public void OnMouseOver()
		{
		}
	}
}
