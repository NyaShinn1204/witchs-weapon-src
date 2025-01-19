using System.Xml;

public static class EmitFactory
{
	public static XmlDocument doc;

	public static XmlReaderSettings set;

	public const string EMIT_TYPE_DEFAULT = "";

	public const string EMIT_TYPE_GROUP = "group";

	public const string EMIT_TYPE_3D = "3D";

	public const string EMIT_TYPE_TIME_3D = "3D_TIME";

	public static Emit ParseEmit(string path, string id)
	{
		return null;
	}
}
