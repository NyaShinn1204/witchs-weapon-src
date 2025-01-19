using UnityEngine;

namespace LeanCloud
{
	public class AVInitializeBehaviour : MonoBehaviour
	{
		[SerializeField]
		public string applicationID;

		[SerializeField]
		public string applicationKey;

		[SerializeField]
		public AVClient.Configuration.AVRegion region;

		[SerializeField]
		public string engineServer;

		[SerializeField]
		public bool useProduction;

		public static bool IsWebPlayer { get; set; }
	}
}
