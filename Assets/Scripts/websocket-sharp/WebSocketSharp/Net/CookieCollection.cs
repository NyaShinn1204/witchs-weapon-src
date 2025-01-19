using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		private List<Cookie> _list;

		private object _sync;

		internal IEnumerable<Cookie> Sorted
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		private static int compareCookieWithinSorted(Cookie x, Cookie y)
		{
			return 0;
		}

		private static CookieCollection parseRequest(string value)
		{
			return null;
		}

		private static CookieCollection parseResponse(string value)
		{
			return null;
		}

		private int searchCookie(Cookie cookie)
		{
			return 0;
		}

		private static string[] splitCookieHeaderValue(string value)
		{
			return null;
		}

		private static string urlDecode(string s, Encoding encoding)
		{
			return null;
		}

		internal static CookieCollection Parse(string value, bool response)
		{
			return null;
		}

		internal void SetOrRemove(Cookie cookie)
		{
		}

		internal void SetOrRemove(CookieCollection cookies)
		{
		}

		public void Add(Cookie cookie)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
