using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class CommonScenePanel : MonoBehaviour
{
	protected List<ButtonEx> btnList;

	public virtual void ClosePanel(Action action = null)
	{
	}

	public virtual void OpenPanel(UIDataBase mData = null)
	{
	}

	protected virtual void AddConfigItem()
	{
	}

	private void InitConfigItemBeforeOpen()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}
}
