using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class UIMapPointLoad : MonoBehaviour
{
	public enum UIMapPointIconType
	{
		complete = 0,
		unlock = 1,
		islock = 2
	}

	public class UIMapPointLoadData
	{
		public long ID;

		public GameObject view;

		public List<UIMapPointLoadData> nextPointData;

		public UIMapPointLoadData prePoint;

		public UIMapPointLine line;

		public bool IsComplete
		{
			get
			{
				return false;
			}
		}

		public TypeCsvInstance csvInstance
		{
			get
			{
				return null;
			}
		}

		public TypeCsvActivity csvActivity
		{
			get
			{
				return null;
			}
		}

		public DrawActivityData serverActivity
		{
			get
			{
				return null;
			}
		}

		public UIMapPointIconType type
		{
			get
			{
				return default(UIMapPointIconType);
			}
		}

		public Vector3 leftLocalPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 rightLocalPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public int minDis
		{
			get
			{
				return 0;
			}
		}
	}

	public class UIMapPointLine
	{
		private UISprite _line;

		public UIMapPointLine preLine;

		public List<UIMapPointLine> nextLine;

		public UIMapPointLoadData beginPoint;

		public List<UIMapPointLoadData> endPoint;

		public UIMapPointIconType endPointType
		{
			get
			{
				return default(UIMapPointIconType);
			}
		}

		public Vector3 endLocalPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public UIMapPointLine(GameObject sLine, UIMapPointLoadData sBeginPoint)
		{
		}

		public void Draw()
		{
		}

		public void Clear()
		{
		}
	}

	private Dictionary<long, UIMapPointLoadData> _pointHash;

	private List<GameObject> _bgList;

	private const string POINT_PATH = "BottomLeft/offset/scrollView/point/Point";

	private const string LINE_PATH = "BottomLeft/offset/scrollView/line/Line";

	public Material material;

	public float lineWidth;

	public List<UIMapPointLoadData> pointList
	{
		get
		{
			return null;
		}
	}

	public List<long> pointID
	{
		get
		{
			return null;
		}
	}

	public Dictionary<long, UIMapPointLoadData> pointHash
	{
		get
		{
			return null;
		}
	}

	public UIMapPointLoadData GetDataByID(long sID)
	{
		return null;
	}

	public void LoadByID(long sID)
	{
	}

	public void LoadByData(TypeCsvMapPoint sData)
	{
	}

	private void DrawPoint(TypeCsvMapPoint sData)
	{
	}

	private void DrawBG(TypeCsvMapPoint sData)
	{
	}

	public void DrawLine()
	{
	}

	public void DrawIcon()
	{
	}

	public void ModfineData()
	{
	}

	public void Clear()
	{
	}
}
