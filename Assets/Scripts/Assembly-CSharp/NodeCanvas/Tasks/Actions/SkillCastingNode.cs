using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class SkillCastingNode : ActionTask, ILogParam
	{
		private Entity entity;

		private long SkillID;

		public string SkillIDStr;

		private Skill skill;

		private bool flag;

		private bool lastFrameComplete;

		[SerializeField]
		public BBParameter<bool> isSkillCating;

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void SkillComplete(bool flag)
		{
		}

		public string ValueToString()
		{
			return null;
		}

		public override void ResetOnStop()
		{
		}
	}
}
