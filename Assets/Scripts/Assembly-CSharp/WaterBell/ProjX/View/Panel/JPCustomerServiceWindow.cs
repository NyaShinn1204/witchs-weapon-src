using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class JPCustomerServiceWindow : MonoBehaviour
	{
		[SerializeField]
		private GameObject FirstStepContainer;

		[SerializeField]
		private GameObject ConsumptionContainer;

		[SerializeField]
		private GameObject BugReportContainer;

		[SerializeField]
		private GameObject SuggestContainer;

		[SerializeField]
		private GameObject OtherContainer;

		[SerializeField]
		private ButtonEx CloseBtn;

		[SerializeField]
		private ButtonEx ConsumptionConfirmBtn;

		[SerializeField]
		private ButtonEx BugReportConfirmBtn;

		[SerializeField]
		private ButtonEx GotoConsumptionContainerBtn;

		[SerializeField]
		private ButtonEx GotoBugReportContainerBtn;

		[SerializeField]
		private ButtonEx GotoSuggestContainerBtn;

		[SerializeField]
		private ButtonEx GotoOtherContainerBtn;

		[SerializeField]
		private UIInput ConsumptionOrderInput;

		[SerializeField]
		private UIInput ConsumptionMonthInput;

		[SerializeField]
		private UIInput ConsumptionDayInput;

		[SerializeField]
		private UIInput ConsumptionHourInput;

		[SerializeField]
		private UIInput ConsumptionMinuteInput;

		[SerializeField]
		private UIInput BugMonthInput;

		[SerializeField]
		private UIInput BugDayInput;

		[SerializeField]
		private UIInput BugHourInput;

		[SerializeField]
		private UIInput BugMinuteInput;

		private void Awake()
		{
		}

		public void Show(JPCustomerServiceWindowType type)
		{
		}

		private void OnClickCloseBtn()
		{
		}

		private void OnConsumptionOrderInput()
		{
		}

		private void OnConsumptionMonthInput()
		{
		}

		private void OnConsumptionDayInput()
		{
		}

		private void OnConsumptionHourInput()
		{
		}

		private void OnConsumptionMinuteInput()
		{
		}

		private void OnBugMonthInput()
		{
		}

		private void OnBugDayInput()
		{
		}

		private void OnBugHourInput()
		{
		}

		private void OnBugMinuteInput()
		{
		}

		private void OnClickConsumptionConfirmBtn()
		{
		}

		private void OnClickBugReportConfirmBtn()
		{
		}

		private void OnClickGotoConsumptionContainerBtn()
		{
		}

		private void OnClickGotoBugReportContainerBtn()
		{
		}

		private void OnClickGotoSuggestContainerBtn()
		{
		}

		private void OnClickGotoOtherContainerBtn()
		{
		}

		private void Close()
		{
		}
	}
}
