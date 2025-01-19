using System.Collections.Generic;
using UnityEngine;

public class UIRedPoint : MonoBehaviour
{
	public enum UIRedPointType
	{
		nil = 0,
		story_all = 1,
		story_group = 2,
		story_main = 3,
		story_sub = 4
	}

	private static List<UIRedPoint> _list;

	[SerializeField]
	private UIRedPointType _type;

	private bool IsParentButtonEnabled
	{
		get
		{
			return false;
		}
	}

	public static void RefreshAll()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Refresh()
	{
	}

	private bool HasStoryAnyCanUnLock()
	{
		return false;
	}

	private bool HashStoryAnyCanUnLockInGroup()
	{
		return false;
	}

	private bool HashStoryAnyCanUnLockInMain()
	{
		return false;
	}

	private bool HashStoryAnyCanUnLockInSub()
	{
		return false;
	}
}
