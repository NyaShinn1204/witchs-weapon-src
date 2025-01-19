using System.Collections.Generic;

namespace ShaderWeaver
{
	public class SWDataManager
	{
		public static bool IsSWShader(string fullPath)
		{
			return false;
		}

		public static void Save(string path, SWData data)
		{
		}

		public static SWData Load(string path)
		{
			return null;
		}

		private static string GetShaderJson(string[] lines)
		{
			return null;
		}

		public static string DataToText(List<SWDataNode> nodes)
		{
			return null;
		}

		public static List<SWDataNode> TextToData(string text)
		{
			return null;
		}

		public static bool StringIsData(string txt)
		{
			return false;
		}

		public static void VersionUpdate(SWData data)
		{
		}

		protected static void VersionUpdate_120(SWData data)
		{
		}

		protected static void VersionUpdate_121(SWData data)
		{
		}

		protected static void VersionUpdate_130(SWData data)
		{
		}

		public static void FixParams(SWData data)
		{
		}

		public static void FixParam(SWData data, ref string param)
		{
		}

		public static bool ParamIsPredefined(SWData data, string param)
		{
			return false;
		}

		public static string NewGUID()
		{
			return null;
		}

		public static void AddConnection(SWDataNode leftNode, int leftPort, SWDataNode rightNode, int rightPort)
		{
		}

		public static void RemoveConnection(SWDataNode parent, SWDataNode child)
		{
		}
	}
}
