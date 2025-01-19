using System.Collections.Generic;
using UnityEngine;

namespace BestHTTP.Examples
{
	public sealed class LargeFileDownloadSample : MonoBehaviour
	{
		private const string URL = "http://uk3.testmy.net/dl-102400";

		private HTTPRequest request;

		private string status;

		private float progress;

		private int fragmentSize;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGUI()
		{
		}

		private void StreamLargeFileTest()
		{
		}

		private void ProcessFragments(List<byte[]> fragments)
		{
		}
	}
}
