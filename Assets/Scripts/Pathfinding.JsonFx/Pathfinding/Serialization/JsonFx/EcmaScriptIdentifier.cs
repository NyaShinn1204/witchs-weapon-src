namespace Pathfinding.Serialization.JsonFx
{
	public class EcmaScriptIdentifier : IJsonSerializable
	{
		private readonly string identifier;

		void IJsonSerializable.WriteJson(JsonWriter writer)
		{
		}

		public static string EnsureValidIdentifier(string varExpr, bool nested)
		{
			return null;
		}

		public static string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty)
		{
			return null;
		}

		public static bool IsValidIdentifier(string varExpr, bool nested)
		{
			return false;
		}

		private static bool IsReservedWord(string varExpr)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
