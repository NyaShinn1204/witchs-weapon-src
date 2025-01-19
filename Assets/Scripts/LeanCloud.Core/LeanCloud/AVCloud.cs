using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;

namespace LeanCloud
{
	public static class AVCloud
	{
		public class Captcha
		{
			public string Token { get; internal set; }

			public string Url { get; internal set; }

			public Task VerifyAsync(string code, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}
		}

		public class RealtimeSignature
		{
			public string Nonce { get; internal set; }

			public long Timestamp { get; internal set; }

			public string ClientId { get; internal set; }

			public string Signature { get; internal set; }
		}

		internal static IAVCloudCodeController CloudCodeController
		{
			get
			{
				return null;
			}
		}

		public static Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters = null, string sesstionToken = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<T> RPCFunctionAsync<T>(string name, IDictionary<string, object> parameters = null, string sesstionToken = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<DateTime> GetServerDateTimeAsync()
		{
			return null;
		}

		public static Task<bool> RequestSMSCodeAsync(string mobilePhoneNumber, string name, string op, int ttl = 10)
		{
			return null;
		}

		public static Task<bool> RequestSMSCodeAsync(string mobilePhoneNumber, string name, string op, int ttl = 10, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<bool> RequestSMSCodeAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> RequestSMSCodeAsync(string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> RequestSMSCodeAsync(string mobilePhoneNumber, string template, IDictionary<string, object> env, string sign = "", string validateToken = "", CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<bool> RequestVoiceCodeAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> VerifySmsCodeAsync(string code, string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> VerifySmsCodeAsync(string code, string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<Captcha> RequestCaptchaAsync(int width = 85, int height = 30, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<string> VerifyCaptchaAsync(string code, string token, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<IDictionary<string, object>> GetCustomParametersAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<RealtimeSignature> RequestRealtimeSignatureAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<RealtimeSignature> RequestRealtimeSignatureAsync(AVUser user, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<string> GetLeanEngineHostingUrlAsync()
		{
			return null;
		}
	}
}
