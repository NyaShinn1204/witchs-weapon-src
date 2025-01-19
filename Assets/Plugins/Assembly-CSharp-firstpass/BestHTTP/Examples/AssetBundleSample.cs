using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace BestHTTP.Examples
{
	public sealed class AssetBundleSample : MonoBehaviour
	{
		private const string URL = "https://besthttp.azurewebsites.net/Content/AssetBundle.html";

		private string status;

		private AssetBundle cachedBundle;

		private Texture2D texture;

		private bool downloading;

		private void OnGUI()
		{
		}

		private void OnDestroy()
		{
		}

		[DebuggerHidden]
		private IEnumerator DownloadAssetBundle()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator ProcessAssetBundle(AssetBundle bundle)
		{
			return null;
		}

		private void UnloadBundle()
		{
		}
	}
}
