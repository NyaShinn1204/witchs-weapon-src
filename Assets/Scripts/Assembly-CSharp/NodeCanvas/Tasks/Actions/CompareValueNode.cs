using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class CompareValueNode : ConditionTask
	{
		public enum ConditionType
		{
			TYPE_EQUALS = 1,
			TYPE_MORE_THAN = 2,
			TYPE_MORE_AND_EQUALS_THAN = 3,
			TYPE_LESS_THAN = 4,
			TYPE_LESS_AND_EQUALS_THAN = 5,
			TYPE_NOR = 6
		}

		public ConditionType conditionType;

		public ValueParam.Type value1Opra;

		public float value1;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr1;

		public int target1type;

		public float target1Argu1;

		public float target1Argu2;

		public float target1Argu3;

		public float target1Argu4;

		public float target1Argu5;

		public int value1Index;

		public string tableArgName1;

		public ValueParam.Type value2Opra;

		public float value2;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr2;

		public int target2type;

		public float target2Argu1;

		public float target2Argu2;

		public float target2Argu3;

		public float target2Argu4;

		public float target2Argu5;

		public int value2Index;

		public string tableArgName2;

		private Entity entity;

		private ValueParam param1;

		private ValueParam param2;

		protected override bool OnCheck()
		{
			return false;
		}

		private string ConvertConditionType(ConditionType type)
		{
			return null;
		}
	}
}
