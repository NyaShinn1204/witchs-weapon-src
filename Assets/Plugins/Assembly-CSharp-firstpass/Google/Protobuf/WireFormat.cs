namespace Google.Protobuf
{
	public static class WireFormat
	{
		public enum WireType : uint
		{
			Varint = 0u,
			Fixed64 = 1u,
			LengthDelimited = 2u,
			StartGroup = 3u,
			EndGroup = 4u,
			Fixed32 = 5u
		}

		private const int TagTypeBits = 3;

		private const uint TagTypeMask = 7u;

		public static WireType GetTagWireType(uint tag)
		{
			return default(WireType);
		}

		public static int GetTagFieldNumber(uint tag)
		{
			return 0;
		}

		public static uint MakeTag(int fieldNumber, WireType wireType)
		{
			return 0u;
		}
	}
}
