using UnityEngine;

namespace WaterBell.ProjX.View.Common
{
	public class CustomInput : MonoBehaviour
	{
		public UISprite ActiveBG;

		public UISprite DisactiveBG;

		public UIInput Input;

		public UILabel Label;

		public UIButton Button;

		public GameObject ButtonObj;

		public bool isActive;

		public string DefaultText;

		private bool isShowClear;

		private void Start()
		{
		}

		public void InputChanged()
		{
		}

		public void ClearInput()
		{
		}

		public void Update()
		{
		}

		public string GetText()
		{
			return null;
		}
	}
}
