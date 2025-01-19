using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WebSocketSharp
{
	internal class WebSocketFrame : IEnumerable<byte>, IEnumerable
	{
		private byte[] _extPayloadLength;

		private Fin _fin;

		private Mask _mask;

		private byte[] _maskingKey;

		private Opcode _opcode;

		private PayloadData _payloadData;

		private byte _payloadLength;

		private Rsv _rsv1;

		private Rsv _rsv2;

		private Rsv _rsv3;

		internal static readonly byte[] EmptyPingBytes;

		internal int ExtendedPayloadLengthCount
		{
			get
			{
				return 0;
			}
		}

		internal ulong FullPayloadLength
		{
			get
			{
				return 0uL;
			}
		}

		public bool IsClose
		{
			get
			{
				return false;
			}
		}

		public bool IsCompressed
		{
			get
			{
				return false;
			}
		}

		public bool IsContinuation
		{
			get
			{
				return false;
			}
		}

		public bool IsData
		{
			get
			{
				return false;
			}
		}

		public bool IsFinal
		{
			get
			{
				return false;
			}
		}

		public bool IsFragment
		{
			get
			{
				return false;
			}
		}

		public bool IsMasked
		{
			get
			{
				return false;
			}
		}

		public bool IsPing
		{
			get
			{
				return false;
			}
		}

		public bool IsPong
		{
			get
			{
				return false;
			}
		}

		public bool IsText
		{
			get
			{
				return false;
			}
		}

		public ulong Length
		{
			get
			{
				return 0uL;
			}
		}

		public Opcode Opcode
		{
			get
			{
				return default(Opcode);
			}
		}

		public PayloadData PayloadData
		{
			get
			{
				return null;
			}
		}

		public Rsv Rsv2
		{
			get
			{
				return default(Rsv);
			}
		}

		public Rsv Rsv3
		{
			get
			{
				return default(Rsv);
			}
		}

		static WebSocketFrame()
		{
		}

		private WebSocketFrame()
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, byte[] data, bool compressed, bool mask)
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, PayloadData payloadData, bool compressed, bool mask)
		{
		}

		private static byte[] createMaskingKey()
		{
			return null;
		}

		private static string dump(WebSocketFrame frame)
		{
			return null;
		}

		private static string print(WebSocketFrame frame)
		{
			return null;
		}

		private static WebSocketFrame processHeader(byte[] header)
		{
			return null;
		}

		private static void readExtendedPayloadLengthAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readHeaderAsync(Stream stream, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readMaskingKeyAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		private static void readPayloadDataAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		internal static WebSocketFrame CreateCloseFrame(PayloadData payloadData, bool mask)
		{
			return null;
		}

		internal static WebSocketFrame CreatePingFrame(bool mask)
		{
			return null;
		}

		internal static WebSocketFrame CreatePongFrame(PayloadData payloadData, bool mask)
		{
			return null;
		}

		internal static void ReadFrameAsync(Stream stream, bool unmask, Action<WebSocketFrame> completed, Action<Exception> error)
		{
		}

		internal void Unmask()
		{
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		public string PrintToString(bool dumped)
		{
			return null;
		}

		public byte[] ToArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
