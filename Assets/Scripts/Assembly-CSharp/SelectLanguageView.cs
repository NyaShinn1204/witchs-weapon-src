using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SelectLanguageView : RegAndLoginSubView
{
	public GameObject Servant_Scroll;

	public GameObject Grid;

	public UILabel Notice;

	public ButtonEx BgBtn;

	public ButtonEx OkBtn;

	public ButtonEx CancelBtn;

	private List<string> languageKey;

	private List<string> languageValue;

	public override void Show()
	{
	}

	private string GetLanguageNmae(int _type)
	{
		return null;
	}

	private ManagerCsv.Language GetLanguageType(string _name)
	{
		return default(ManagerCsv.Language);
	}

	private void DestroyItem()
	{
	}

	public void FreshItem()
	{
	}

	public override void Hide()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickOKBtn()
	{
	}

	private void ConfirmChangeLanguage()
	{
	}

	private void OnClickBgBtn()
	{
	}

	public void ShowOldDirectLoginError()
	{
	}
}
