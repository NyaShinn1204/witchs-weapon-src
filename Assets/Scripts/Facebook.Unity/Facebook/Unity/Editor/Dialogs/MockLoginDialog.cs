namespace Facebook.Unity.Editor.Dialogs
{
	internal class MockLoginDialog : EditorFacebookMockDialog
	{
		private string accessToken;

		protected override string DialogTitle
		{
			get
			{
				return null;
			}
		}

		protected override void DoGui()
		{
		}

		protected override void SendSuccessResult()
		{
		}
	}
}
