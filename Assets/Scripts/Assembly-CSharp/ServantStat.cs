using System;

[Serializable]
public class ServantStat
{
	public int idx;

	public int prefabID;

	public int starNum;

	public int wpType;

	public MainAttr attrSet;

	public EnergyAttr erSet;

	public int rank;

	public int rankCol
	{
		get
		{
			return 0;
		}
	}

	public int rankValue
	{
		get
		{
			return 0;
		}
	}

	public string ServantName
	{
		get
		{
			return null;
		}
	}
}
