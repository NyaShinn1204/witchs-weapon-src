using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	public static class AVClient
	{
		public struct Configuration
		{
			public enum AVRegion
			{
				[Obsolete]
				Public_CN = 0,
				Public_North_China = 0,
				[Obsolete]
				Public_US = 1,
				Public_North_America = 1,
				[Obsolete]
				Vendor_Tencent = 2,
				Public_East_China = 2
			}

			[StructLayout(LayoutKind.Sequential, Size = 24)]
			public struct VersionInformation
			{
				public string BuildVersion { get; set; }

				public string DisplayVersion { get; set; }

				public string OSVersion { get; set; }
			}

			public string ApplicationId { get; set; }

			public AVRegion Region { get; set; }

			internal int RegionValue
			{
				get
				{
					return 0;
				}
			}

			public string ApplicationKey { get; set; }

			public string MasterKey { get; set; }

			public IDictionary<string, string> AdditionalHTTPHeaders { get; set; }

			public VersionInformation VersionInfo { get; set; }

			public Uri EngineServer { get; set; }

			public Uri ApiServer { get; set; }

			public Uri PushServer { get; set; }

			public Uri StatsServer { get; set; }
		}

		public static readonly string[] DateFormatStrings;

		private static readonly object mutex;

		private static readonly string versionString;

		private static bool useProduction;

		private static bool useMasterKey;

		public static Configuration CurrentConfiguration { get; internal set; }

		internal static Version Version
		{
			get
			{
				return null;
			}
		}

		public static string VersionString
		{
			get
			{
				return null;
			}
		}

		internal static Action<string> LogTracker { get; private set; }

		public static bool UseProduction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool UseMasterKey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static AVClient()
		{
		}

		public static void Initialize(string applicationId, string applicationKey)
		{
		}

		public static void HttpLog(Action<string> trace)
		{
		}

		public static void PrintLog(string log)
		{
		}

		public static void Initialize(Configuration configuration)
		{
		}

		internal static void Config(Configuration configuration)
		{
		}

		internal static void Clear()
		{
		}

		public static void Switch(Configuration configuration)
		{
		}

		public static void Switch(string applicationId, string applicationKey, Configuration.AVRegion region = Configuration.AVRegion.Public_CN)
		{
		}

		public static string BuildQueryString(IDictionary<string, object> parameters)
		{
			return null;
		}

		internal static IDictionary<string, string> DecodeQueryString(string queryString)
		{
			return null;
		}

		internal static IDictionary<string, object> DeserializeJsonString(string jsonData)
		{
			return null;
		}

		internal static string SerializeJsonString(IDictionary<string, object> jsonData)
		{
			return null;
		}

		public static Task<Tuple<HttpStatusCode, string>> HttpGetAsync(Uri uri)
		{
			return null;
		}

		public static Task<Tuple<HttpStatusCode, string>> RequestAsync(Uri uri, string method, IList<KeyValuePair<string, string>> headers, IDictionary<string, object> body, string contentType, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<Tuple<HttpStatusCode, string>> RequestAsync(Uri uri, string method, IList<KeyValuePair<string, string>> headers, Stream data, string contentType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Tuple<HttpStatusCode, IDictionary<string, object>> ReponseResolve(Tuple<HttpStatusCode, string> response, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RequestAsync(string method, Uri relativeUri, string sessionToken, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RunCommandAsync(AVCommand command)
		{
			return null;
		}

		internal static bool IsSuccessStatusCode(HttpStatusCode responseStatus)
		{
			return false;
		}

		public static string ToLog(this HttpRequest request)
		{
			return null;
		}
	}
}
