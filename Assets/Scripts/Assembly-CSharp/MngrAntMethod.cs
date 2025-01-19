using System.Collections.Generic;
using UnityEngine;

public class MngrAntMethod : MonoBehaviour
{
	public interface IMngrAntMethod
	{
		float SortID { get; }

		bool IsDoneOver { get; }

		bool IsRunInBattle { get; }

		void Done();
	}

	public class IComparerANT : IComparer<IMngrAntMethod>
	{
		public int Compare(IMngrAntMethod x, IMngrAntMethod y)
		{
			return 0;
		}
	}

	private static MngrAntMethod _instance;

	private List<IMngrAntMethod> _ANTList;

	private List<IMngrAntMethod> _ANTListInBattle;

	private bool _isDone;

	private bool _isRun;

	public static MngrAntMethod instance
	{
		get
		{
			return null;
		}
	}

	public bool Run
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int GetCurrPlayListLen()
	{
		return 0;
	}

	public bool GetCurrPlayListContainsGuide()
	{
		return false;
	}

	public void AddAnt(IMngrAntMethod sANT)
	{
	}

	private void Update()
	{
	}

	private void Done(List<IMngrAntMethod> sAntList)
	{
	}
}
