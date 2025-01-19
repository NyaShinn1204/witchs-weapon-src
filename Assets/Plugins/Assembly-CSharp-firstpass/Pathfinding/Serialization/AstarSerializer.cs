using System.IO;
using System.Text;
using Pathfinding.Ionic.Zip;
using Pathfinding.Serialization.JsonFx;

namespace Pathfinding.Serialization
{
	public class AstarSerializer
	{
		private AstarData data;

		public JsonWriterSettings writerSettings;

		public JsonReaderSettings readerSettings;

		private ZipFile zip;

		private MemoryStream str;

		private GraphMeta meta;

		private SerializeSettings settings;

		private NavGraph[] graphs;

		private const string binaryExt = ".binary";

		private const string jsonExt = ".json";

		private uint checksum;

		private UTF8Encoding encoding;

		private static StringBuilder _stringBuilder;

		public AstarSerializer(AstarData data)
		{
		}

		public AstarSerializer(AstarData data, SerializeSettings settings)
		{
		}

		private static StringBuilder GetStringBuilder()
		{
			return null;
		}

		public void AddChecksum(byte[] bytes)
		{
		}

		public uint GetChecksum()
		{
			return 0u;
		}

		public void OpenSerialize()
		{
		}

		public byte[] CloseSerialize()
		{
			return null;
		}

		public void SerializeGraphs(NavGraph[] _graphs)
		{
		}

		public void SerializeUserConnections(UserConnection[] conns)
		{
		}

		private byte[] SerializeMeta()
		{
			return null;
		}

		public byte[] Serialize(NavGraph graph)
		{
			return null;
		}

		public void SerializeNodes()
		{
		}

		private byte[] SerializeNodes(int index)
		{
			return null;
		}

		public void SerializeExtraInfo()
		{
		}

		private byte[] SerializeNodeConnections(int index)
		{
			return null;
		}

		public void SerializeEditorSettings(GraphEditorBase[] editors)
		{
		}

		public bool OpenDeserialize(byte[] bytes)
		{
			return false;
		}

		public void CloseDeserialize()
		{
		}

		public NavGraph[] DeserializeGraphs()
		{
			return null;
		}

		public UserConnection[] DeserializeUserConnections()
		{
			return null;
		}

		public void DeserializeNodes()
		{
		}

		public void DeserializeExtraInfo()
		{
		}

		public void PostDeserialization()
		{
		}

		private void DeserializeNodes(int index, BinaryReader reader)
		{
		}

		private void DeserializeNodeConnections(int index, BinaryReader reader)
		{
		}

		public void DeserializeEditorSettings(GraphEditorBase[] graphEditors)
		{
		}

		private string GetString(ZipEntry entry)
		{
			return null;
		}

		private GraphMeta DeserializeMeta(ZipEntry entry)
		{
			return null;
		}

		public static void SaveToFile(string path, byte[] data)
		{
		}

		public static byte[] LoadFromFile(string path)
		{
			return null;
		}
	}
}
