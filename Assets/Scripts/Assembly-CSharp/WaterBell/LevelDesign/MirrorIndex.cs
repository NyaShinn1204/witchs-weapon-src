using System.Collections.Generic;
using Rolemod;

namespace WaterBell.LevelDesign
{
	public class MirrorIndex
	{
		public class MirrorInfo
		{
			public string intro;

			public MirrorType type;

			public long id;

			public bool isExisted;
		}

		private static MirrorIndex _instance;

		private static bool isRemoteDataLoaded;

		private List<MirrorInfo> spMI;

		private List<MirrorInfo> guideMI;

		private List<MirrorInfo> achieveMI;

		private List<MirrorInfo> uiMI;

		private List<MirrorInfo> combatMI;

		private List<MirrorInfo> elseMI;

		private List<List<MirrorInfo>> cache;

		public static MirrorIndex GetInstance()
		{
			return null;
		}

		public void InitParseCsv()
		{
		}

		public static bool GetIsRemoteDataLoaded()
		{
			return false;
		}

		public void ParseMirrorProtobufData(RoleMirror mrr)
		{
		}

		public void MarkMirrorInfoAsExisted(long mID)
		{
		}

		private int ExtraMirrorTypeIntFromID(long mirrorID)
		{
			return 0;
		}

		private MirrorInfo SearchMirrorInfoByID(long mID)
		{
			return null;
		}

		private static int CompareByMirrorID(MirrorInfo x, MirrorInfo y)
		{
			return 0;
		}

		private void ClearMirror()
		{
		}

		private void ParseMirror()
		{
		}

		public List<MirrorInfo> GetMirrorList(int mTypeIdx)
		{
			return null;
		}

		public MirrorInfo GetMirrorInfo(int mTypeIdx, int innerIdx)
		{
			return null;
		}
	}
}
