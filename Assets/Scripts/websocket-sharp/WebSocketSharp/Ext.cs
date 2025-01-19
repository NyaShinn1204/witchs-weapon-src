using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	public static class Ext
	{
		private static readonly byte[] _last;

		private static readonly int _retry;

		private static MemoryStream compress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream decompress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompressToArray(this Stream stream)
		{
			return null;
		}

		internal static byte[] Append(this ushort code, string reason)
		{
			return null;
		}

		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool Contains(this string value, params char[] anyOf)
		{
			return false;
		}

		internal static bool Contains(this NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue)
		{
			return false;
		}

		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			return false;
		}

		internal static bool ContainsTwice(this string[] values)
		{
			return false;
		}

		internal static void CopyTo(this Stream source, Stream destination, int bufferLength)
		{
		}

		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool EqualsWith(this int value, char c, Action<int> action)
		{
			return false;
		}

		internal static string GetAbsolutePath(this Uri uri)
		{
			return null;
		}

		internal static CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			return null;
		}

		internal static string GetMessage(this CloseStatusCode code)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ushort value, ByteOrder order)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ulong value, ByteOrder order)
		{
			return null;
		}

		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			return false;
		}

		internal static bool IsControl(this byte opcode)
		{
			return false;
		}

		internal static bool IsData(this byte opcode)
		{
			return false;
		}

		internal static bool IsData(this Opcode opcode)
		{
			return false;
		}

		internal static bool IsReserved(this ushort code)
		{
			return false;
		}

		internal static bool IsSupported(this byte opcode)
		{
			return false;
		}

		internal static bool IsText(this string value)
		{
			return false;
		}

		internal static bool IsToken(this string value)
		{
			return false;
		}

		internal static byte[] ReadBytes(this Stream stream, int length)
		{
			return null;
		}

		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength)
		{
			return null;
		}

		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static T[] Reverse<T>(this T[] array)
		{
			return null;
		}

		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			return null;
		}

		internal static byte[] ToByteArray(this Stream stream)
		{
			return null;
		}

		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			return null;
		}

		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			return 0;
		}

		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			return 0uL;
		}

		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message)
		{
			result = null;
			message = null;
			return false;
		}

		internal static bool TryGetUTF8EncodedBytes(this string s, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		internal static string Unquote(this string value)
		{
			return null;
		}

		internal static bool Upgrades(this NameValueCollection headers, string protocol)
		{
			return false;
		}

		internal static string UTF8Decode(this byte[] bytes)
		{
			return null;
		}

		internal static byte[] UTF8Encode(this string s)
		{
			return null;
		}

		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
		}

		public static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
		}

		public static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
		}

		public static bool IsEnclosedIn(this string value, char c)
		{
			return false;
		}

		public static bool IsHostOrder(this ByteOrder order)
		{
			return false;
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return false;
		}

		public static bool IsPredefinedScheme(this string value)
		{
			return false;
		}

		public static bool MaybeUri(this string value)
		{
			return false;
		}

		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			return null;
		}

		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			return null;
		}

		public static void Times(this int n, Action<int> action)
		{
		}

		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			return null;
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return null;
		}

		public static Uri ToUri(this string value)
		{
			return null;
		}
	}
}
