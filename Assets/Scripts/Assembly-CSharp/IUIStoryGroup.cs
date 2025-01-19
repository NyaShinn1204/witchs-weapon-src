public interface IUIStoryGroup
{
	bool IsSwitchShowType { get; set; }

	void Update(UIStoryList sStoryList, long sIDSelectStory);

	UIStoryView GetGroupViewIcon(long sIDGroup);

	void Hide();

	void Show();

	void DrawView();
}
