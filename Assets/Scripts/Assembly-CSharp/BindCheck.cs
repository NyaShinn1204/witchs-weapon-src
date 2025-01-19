using UnityEngine;

public class BindCheck : MonoBehaviour
{
	public ButtonEx CannelBtn;

	public ButtonEx CheckIdCardBtn;

	public UIInput InputName;

	public UIInput InputIdCard;

	public UILabel errorCodeText;

	private string GetName
	{
		get
		{
			return null;
		}
	}

	private string GetIdCard
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void Check()
	{
	}

	private void GetBindLoot(ModelCollection<DrawResultData> _loot, ModelCollection<DrawResultData> _weapon)
	{
	}

	private void CheckSuccessful()
	{
	}

	private void CheckFail(string _error)
	{
	}
}
