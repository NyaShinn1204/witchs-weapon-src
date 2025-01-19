using UnityEngine;

public class FavorConditionItem : MonoBehaviour
{
	public UILabel condition;

	public UILabel value;

	public ButtonEx checkBtn;

	public ButtonEx getAwardBtn;

	public Transform finishBtn;

	public Transform lockBtn;

	private bool isTask;

	private int index;

	private int serial;

	private Color color1;

	private Color color2;

	public UILabel text;

	private void Awake()
	{
	}

	public void SetInfo(SingleServantViewModel model, TypeCsvAchievement _data, bool _isTask)
	{
	}

	public void SetInfo(int _serial, int _index, bool _isFavFetched, bool _hasSkin, string _text, string _condtion)
	{
	}

	private void SetColor(bool _unLock)
	{
	}
}
