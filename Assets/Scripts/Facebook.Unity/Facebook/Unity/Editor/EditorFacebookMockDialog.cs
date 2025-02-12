using UnityEngine;

namespace Facebook.Unity.Editor
{
	internal abstract class EditorFacebookMockDialog : MonoBehaviour
	{
		private Rect modalRect;

		private GUIStyle modalStyle;

		public Utilities.Callback<ResultContainer> Callback { protected get; set; }

		public string CallbackID { protected get; set; }

		protected abstract string DialogTitle { get; }

		public void Start()
		{
		}

		public void OnGUI()
		{
		}

		protected abstract void DoGui();

		protected abstract void SendSuccessResult();

		protected virtual void SendCancelResult()
		{
		}

		protected virtual void SendErrorResult(string errorMessage)
		{
		}

		private void OnGUIDialog(int windowId)
		{
		}
	}
}
