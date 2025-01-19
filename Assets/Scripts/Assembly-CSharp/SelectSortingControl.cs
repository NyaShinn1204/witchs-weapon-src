using System.Collections.Generic;
using UnityEngine;

public class SelectSortingControl : MonoBehaviour
{
	public enum panels
	{
		requestPanel = 0,
		selectMercenaryPanel = 1
	}

	public enum SortGuild
	{
		Default = 0,
		Fighting = 1,
		Number = 2
	}

	public enum SortSelectMercenary
	{
		Default = 0,
		Level = 1,
		Id = 2,
		Fighting = 3
	}

	public ButtonEx MainBtn;

	public ButtonEx[] Btns;

	public Animator sorting;

	public TweenHeight tween;

	public UILabel[] BtnTexts;

	public UILabel MainBtnText;

	public SortGuild currentSort;

	public SortSelectMercenary currentSortSelect;

	public panels currentPanel;

	private Dictionary<int, SortGuild> SortGuilds;

	private Dictionary<int, string> SortGuildsBtnText;

	private Dictionary<int, SortSelectMercenary> SortSelectMercenarys;

	private Dictionary<int, string> SortSelectBtnText;

	public ButtonEx BgBox;

	private bool IsOpen;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void Close()
	{
	}

	private void Select(int index)
	{
	}

	private void Open()
	{
	}

	private void Play()
	{
	}

	private void PlayBack()
	{
	}

	private void SetSelectMercenary()
	{
	}

	private void SetGuild()
	{
	}
}
