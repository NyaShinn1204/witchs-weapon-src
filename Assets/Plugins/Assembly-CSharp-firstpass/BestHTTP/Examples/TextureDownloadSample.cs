using UnityEngine;

namespace BestHTTP.Examples
{
	public sealed class TextureDownloadSample : MonoBehaviour
	{
		private const string BaseURL = "https://besthttp.azurewebsites.net/Content/";

		private string[] Images;

		private Texture2D[] Textures;

		private bool allDownloadedFromLocalCache;

		private int finishedCount;

		private Vector2 scrollPos;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGUI()
		{
		}

		private void DownloadImages()
		{
		}

		private void ImageDownloaded(HTTPRequest req, HTTPResponse resp)
		{
		}
	}
}
