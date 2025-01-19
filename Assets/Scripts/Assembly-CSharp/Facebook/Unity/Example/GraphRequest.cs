using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace Facebook.Unity.Example
{
	internal class GraphRequest : MenuBase
	{
		private string apiQuery;

		private Texture2D profilePic;

		protected override void GetGui()
		{
		}

		private void ProfilePhotoCallback(IGraphResult result)
		{
		}

		[DebuggerHidden]
		private IEnumerator TakeScreenshot()
		{
			return null;
		}
	}
}
