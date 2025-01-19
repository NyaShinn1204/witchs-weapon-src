using UnityEngine;

public class APaymentHelper
{
	public class PayResult
	{
		public const string PAY_SUCCESS = "0";

		public const string PAY_FAILURE = "1";

		public const string PAY_ORDER_NO = "2";
	}

	public class LoginResult
	{
		public const string LOGOUT = "0";

		public const string LOGIN_SUCCESS = "1";

		public const string LOGIN_FAILED = "2";
	}

	public class ExitResult
	{
		public const string SDKEXIT = "0";

		public const string SDKEXIT_NO_PROVIDE = "1";
	}

	private AndroidJavaClass klass;

	private static APaymentHelper _instance;

	public static APaymentHelper Instance
	{
		get
		{
			return null;
		}
	}

	public void Init()
	{
	}

	public void Pay(string payId, string gameObject, string runtimeScriptMethod, string usedPrice, string remained)
	{
	}

	public void Exit()
	{
	}

	public bool isPaid(string id)
	{
		return false;
	}

	public void setPaid(string id, bool paid)
	{
	}

	public string getPayingResult(string id)
	{
		return null;
	}

	public long getUserId()
	{
		return 0L;
	}
}
