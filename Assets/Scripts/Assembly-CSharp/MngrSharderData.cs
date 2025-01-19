using System.Collections.Generic;
using UnityEngine;

public class MngrSharderData
{
	public class MngrSharderDataValue
	{
		private GameObject _view;

		private int _shaderBaseCount;

		private Dictionary<string, int> _shader;

		public int shaderBaseCount
		{
			get
			{
				return 0;
			}
		}

		public int shaderCount
		{
			get
			{
				return 0;
			}
		}

		public MngrSharderDataValue(GameObject sView)
		{
		}

		public void addShader(string sShader)
		{
		}

		public void subShader(string sShader)
		{
		}

		private void changeMaterial()
		{
		}
	}

	private static MngrSharderData _instance;

	private static Dictionary<string, Color> _defaultColor;

	private static Dictionary<GameObject, MngrSharderDataValue> _data;

	public static MngrSharderData instance
	{
		get
		{
			return null;
		}
	}

	public MngrSharderDataValue Item
	{
		get
		{
			return null;
		}
	}

	public static Color getColor(string sShader)
	{
		return default(Color);
	}

	public void clear()
	{
	}
}
