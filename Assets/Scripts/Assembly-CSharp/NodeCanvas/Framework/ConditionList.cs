using System.Collections.Generic;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework
{
	[DoNotList]
	public class ConditionList : ConditionTask
	{
		public enum ConditionsCheckMode
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}

		public ConditionsCheckMode checkMode;

		public List<ConditionTask> conditions;

		private List<ConditionTask> initialActiveConditions;

		private bool allTrueRequired
		{
			get
			{
				return false;
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return false;
		}

		public override void OnDrawGizmos()
		{
		}

		public override void OnDrawGizmosSelected()
		{
		}

		public void AddCondition(ConditionTask condition)
		{
		}
	}
}
