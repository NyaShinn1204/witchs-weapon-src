using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class IsActive : ConditionTask<Transform>
	{
		protected override bool OnCheck()
		{
			return false;
		}
	}
}
