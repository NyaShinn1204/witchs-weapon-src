using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckUnityObject : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<Object> valueA;

		public BBParameter<Object> valueB;

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
	}
}
