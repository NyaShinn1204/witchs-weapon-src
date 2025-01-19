using System.IO;
using BestHTTP.Decompression.Zlib;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket.Extensions
{
	public sealed class PerMessageCompression : IExtension
	{
		private static readonly byte[] Trailer;

		private MemoryStream compressorOutputStream;

		private DeflateStream compressorDeflateStream;

		private MemoryStream decompressorInputStream;

		private MemoryStream decompressorOutputStream;

		private DeflateStream decompressorDeflateStream;

		private byte[] copyBuffer;

		public bool ClientNoContextTakeover { get; private set; }

		public bool ServerNoContextTakeover { get; private set; }

		public int ClientMaxWindowBits { get; private set; }

		public int ServerMaxWindowBits { get; private set; }

		public CompressionLevel Level { get; private set; }

		public int MinimumDataLegthToCompress { get; set; }

		public PerMessageCompression()
		{
		}

		public PerMessageCompression(CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress)
		{
		}

		public void AddNegotiation(HTTPRequest request)
		{
		}

		public bool ParseNegotiation(WebSocketResponse resp)
		{
			return false;
		}

		public byte GetFrameHeader(WebSocketFrame writer, byte inFlag)
		{
			return 0;
		}

		public byte[] Encode(WebSocketFrame writer)
		{
			return null;
		}

		public byte[] Decode(byte header, byte[] data)
		{
			return null;
		}

		private byte[] Compress(byte[] data)
		{
			return null;
		}

		private byte[] Decompress(byte[] data)
		{
			return null;
		}
	}
}
