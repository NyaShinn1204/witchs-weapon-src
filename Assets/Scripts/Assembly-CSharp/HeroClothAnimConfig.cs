using System;
using System.Collections.Generic;
using UnityEngine;

public class HeroClothAnimConfig : MonoBehaviour
{
	[Serializable]
	public class SingleConfig
	{
		public long id;

		public string standby;
	}

	public SingleConfig defaultConfig;

	public List<SingleConfig> configList;
}
