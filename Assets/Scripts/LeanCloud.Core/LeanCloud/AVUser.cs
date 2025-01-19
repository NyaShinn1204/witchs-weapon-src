using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;

namespace LeanCloud
{
	public class AVUser : AVObject
	{
		private static readonly IDictionary<string, IAVAuthenticationProvider> authProviders;

		private static readonly HashSet<string> readOnlyKeys;

		private static readonly object isRevocableSessionEnabledMutex;

		private static bool isRevocableSessionEnabled;

		internal static IAVUserController UserController
		{
			get
			{
				return null;
			}
		}

		internal static IAVCurrentUserController CurrentUserController
		{
			get
			{
				return null;
			}
		}

		[Obsolete]
		public bool IsAuthenticated
		{
			get
			{
				return false;
			}
		}

		public string SessionToken
		{
			get
			{
				return null;
			}
		}

		internal static string CurrentSessionToken
		{
			get
			{
				return null;
			}
		}

		public string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Password
		{
			private get
			{
				return null;
			}
			set
			{
			}
		}

		public string Email
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MobilePhoneNumber
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MobilePhoneVerified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAnonymous
		{
			get
			{
				return false;
			}
		}

		public static AVUser CurrentUser
		{
			get
			{
				return null;
			}
		}

		public static AVQuery<AVUser> Query
		{
			get
			{
				return null;
			}
		}

		internal static bool IsRevocableSessionEnabled
		{
			get
			{
				return false;
			}
		}

		internal IDictionary<string, IDictionary<string, object>> AuthData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Task<bool> IsAuthenticatedAsync()
		{
			return null;
		}

		public Task RefreshSessionTokenAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Remove(string key)
		{
		}

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}

		internal override void HandleSave(IObjectState serverState)
		{
		}

		internal static Task<string> GetCurrentSessionTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal Task SetSessionTokenAsync(string newSessionToken)
		{
			return null;
		}

		internal Task SetSessionTokenAsync(string newSessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task SignUpAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task SignUpAsync()
		{
			return null;
		}

		public Task SignUpAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<bool> FollowAsync(string userObjectId)
		{
			return null;
		}

		public Task<bool> FollowAsync(string userObjectId, IDictionary<string, object> data)
		{
			return null;
		}

		public Task<bool> UnfollowAsync(string userObjectId)
		{
			return null;
		}

		public AVQuery<AVUser> GetFollowerQuery()
		{
			return null;
		}

		public AVQuery<AVUser> GetFolloweeQuery()
		{
			return null;
		}

		public AVQuery<AVUser> GetFollowersAndFolloweesQuery()
		{
			return null;
		}

		public Task<IEnumerable<AVUser>> GetFollowersAsync()
		{
			return null;
		}

		public Task<IEnumerable<AVUser>> GetFolloweesAsync()
		{
			return null;
		}

		public static Task<AVUser> LogInAsync(string username, string password)
		{
			return null;
		}

		public static Task<AVUser> LogInAsync(string username, string password, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<AVUser> BecomeAsync(string sessionToken)
		{
			return null;
		}

		public static Task<AVUser> BecomeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		protected override Task SaveAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		internal override Task<AVObject> FetchAsyncInternal(Task toAwait, IDictionary<string, object> queryString, CancellationToken cancellationToken)
		{
			return null;
		}

		public static void LogOut()
		{
		}

		public static Task LogOutAsync()
		{
			return null;
		}

		public static Task LogOutAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task LogOutAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		private static void LogOutWithProviders()
		{
		}

		public static Task<AVUser> GetCurrentAsync()
		{
			return null;
		}

		public static Task<AVUser> GetCurrentUserAsync()
		{
			return null;
		}

		internal static Task<AVUser> GetCurrentUserAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private static Task SaveCurrentUserAsync(AVUser user)
		{
			return null;
		}

		private static Task SaveCurrentUserAsync(AVUser user, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void ClearInMemoryUser()
		{
		}

		public static Task EnableRevocableSessionAsync()
		{
			return null;
		}

		public static Task EnableRevocableSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void DisableRevocableSession()
		{
		}

		internal Task UpgradeToRevocableSessionAsync()
		{
			return null;
		}

		public Task UpgradeToRevocableSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task UpgradeToRevocableSessionAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task RequestPasswordResetAsync(string email)
		{
			return null;
		}

		public static Task RequestPasswordResetAsync(string email, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task UpdatePassword(string oldPassword, string newPassword, CancellationToken cancellationToken)
		{
			return null;
		}

		private static IAVAuthenticationProvider GetProvider(string providerName)
		{
			return null;
		}

		private void CleanupAuthData()
		{
		}

		private void SynchronizeAllAuthData()
		{
		}

		private void SynchronizeAuthData(IAVAuthenticationProvider provider)
		{
		}

		public Task LinkWithAsync(string authType, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task LinkWithAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task UnlinkFromAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal bool IsLinked(string authType)
		{
			return false;
		}

		internal static Task<AVUser> LogInWithAsync(string authType, IDictionary<string, object> data, bool failOnNotExist, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<AVUser> LogInWithAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void RegisterProvider(IAVAuthenticationProvider provider)
		{
		}

		internal static Task<AVUser> LogInWithParametersAsync(Dictionary<string, object> strs, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<AVUser> LogInByMobilePhoneNumberAsync(string mobilePhoneNumber, string password)
		{
			return null;
		}

		public static Task<AVUser> LogInBySmsCodeAsync(string mobilePhoneNumber, string smsCode)
		{
			return null;
		}

		public static Task<AVUser> LogInByEmailAsync(string email, string password, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<AVUser> LogInByMobilePhoneNumberAsync(string mobilePhoneNumber, string password, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<AVUser> LogInBySmsCodeAsync(string mobilePhoneNumber, string smsCode, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<bool> RequestLogInSmsCodeAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> RequestLogInSmsCodeAsync(string mobilePhoneNumber, string validateToken)
		{
			return null;
		}

		public static Task<bool> RequestLogInSmsCodeAsync(string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> RequestLogInSmsCodeAsync(string mobilePhoneNumber, string validateToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<AVUser> SignUpOrLogInByMobilePhoneAsync(string mobilePhoneNumber, string smsCode, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<AVUser> SignUpOrLogInByMobilePhoneAsync(string mobilePhoneNumber, string smsCode)
		{
			return null;
		}

		public static Task SendSignUpSmsCodeAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<AVUser> SignUpByMobilePhoneAsync(string mobilePhoneNumber, string smsCode)
		{
			return null;
		}

		public static Task SendLogInSmsCodeAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<AVUser> LogInByMobilePhoneAsync(string mobilePhoneNumber, string smsCode)
		{
			return null;
		}

		public static Task RequestPasswordResetBySmsCode(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task RequestPasswordResetBySmsCode(string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task RequestPasswordResetBySmsCode(string mobilePhoneNumber, string validateToken)
		{
			return null;
		}

		public static Task RequestPasswordResetBySmsCode(string mobilePhoneNumber, string validateToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> ResetPasswordBySmsCodeAsync(string newPassword, string smsCode)
		{
			return null;
		}

		public static Task<bool> ResetPasswordBySmsCodeAsync(string newPassword, string smsCode, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> RequestMobilePhoneVerifyAsync(string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> RequestMobilePhoneVerifyAsync(string mobilePhoneNumber, string validateToken)
		{
			return null;
		}

		public static Task<bool> RequestMobilePhoneVerifyAsync(string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> RequestMobilePhoneVerifyAsync(string mobilePhoneNumber, string validateToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> VerifyMobilePhoneAsync(string code, string mobilePhoneNumber)
		{
			return null;
		}

		public static Task<bool> VerifyMobilePhoneAsync(string code, string mobilePhoneNumber, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> VerifyMobilePhoneAsync(string code)
		{
			return null;
		}

		public static Task<bool> VerifyMobilePhoneAsync(string code, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<bool> RequestEmailVerifyAsync(string email)
		{
			return null;
		}

		internal Task Create()
		{
			return null;
		}

		internal Task Create(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task Create(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<string> TakeSessionToken(string sesstionToken = null)
		{
			return null;
		}

		public IDictionary<string, IDictionary<string, object>> GetAuthData()
		{
			return null;
		}

		public static Task<AVUser> LogInWithAuthDataAsync(IDictionary<string, object> data, string platform, AVUserAuthDataLogInOption options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<AVUser> LogInWithAuthDataAndUnionIdAsync(IDictionary<string, object> authData, string platform, string unionId, AVUserAuthDataLogInOption options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static Task<AVUser> LogInAnonymouslyAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[Obsolete]
		public static Task<AVUser> LogInWithAsync(string authType, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task AssociateAuthDataAsync(IDictionary<string, object> data, string platform, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task AssociateAuthDataAndUnionIdAsync(IDictionary<string, object> authData, string platform, string unionId, AVUserAuthDataLogInOption options = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task DisassociateWithAuthDataAsync(string platform, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		private static void MergeAuthData(IDictionary<string, object> authData, string unionId, AVUserAuthDataLogInOption options)
		{
		}
	}
}
