namespace Facebook.Unity.Editor.Dialogs
{
	internal class EmptyMockDialog : EditorFacebookMockDialog
	{
		public string EmptyDialogTitle { get; set; }

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
