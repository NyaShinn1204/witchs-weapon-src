using System.Collections.Generic;
using UnityEngine;

public class GUtilUpdate : MonoBehaviour
{
	public class GUtilUpdateData
	{
		private Function _function;

		private bool _isPauseControl;

		private double _callTime;

		private float _callDelat;

		private int _callCount;

		protected int _count;

		private double _createTimeStamp;

		public Function function
		{
			get
			{
				return null;
			}
		}

		public bool isPauseControl
		{
			get
			{
				return false;
			}
		}

		public double callTime
		{
			get
			{
				return 0.0;
			}
		}

		public float callDelat
		{
			get
			{
				return 0f;
			}
		}

		public int callCount
		{
			get
			{
				return 0;
			}
		}

		public bool isCanCall
		{
			get
			{
				return false;
			}
		}

		public bool isCanRemove
		{
			get
			{
				return false;
			}
		}

		public GUtilUpdateData(Function sFunction, bool sIsPauseControl, float sTime, float sDelat, int sCount)
		{
		}

		public void setOffsetDelat(float sTime)
		{
		}

		public void done()
		{
		}
	}

	private static List<GUtilUpdateData> _updateData;

	private static GUtilUpdate _controll;

	public static void init()
	{
	}

	public static GUtilUpdateData addUpdate(Function sEvent, bool sIsPauseControl = true)
	{
		return null;
	}

	public static GUtilUpdateData addUpdateTime(Function sEvent, float sTime, bool sIsPauseControl = true, float sDelat = 0f)
	{
		return null;
	}

	public static GUtilUpdateData addUpdateCount(Function sEvent, int sCount, bool sIsPauseControl = true, float sDelat = 0f)
	{
		return null;
	}

	public static GUtilUpdateData addUpdateDelat(Function sEvent, float sDelat, bool sIsPauseControl = true)
	{
		return null;
	}

	public static void removeHasEvent(Function sEvent)
	{
	}

	public static void removeHasEventAll()
	{
	}

	private void Update()
	{
	}

	private void eventTime()
	{
	}

	private void eventListener()
	{
	}

	private void eventDebug()
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}
}
