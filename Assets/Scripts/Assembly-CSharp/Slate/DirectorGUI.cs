using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Slate
{
	[ExecuteInEditMode]
	public class DirectorGUI : MonoBehaviour
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void SubtitlesGUIDelegate(string text, Color color);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void TextOverlayGUIDelegate(string text, Color color, float size, TextAnchor alignment, Vector2 position);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void TextureOverlayGUIDelegate(Texture texture, Color color, Vector2 position, Vector2 scale);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void ScreenFadeGUIDelegate(Color color);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void LetterboxGUIDelegate(float completion);

		public Font subtitlesFont;

		public Font overlayTextFont;

		private const float CINEBOX_SIZE = 20f;

		private const float SUBS_SIZE = 18f;

		[NonSerialized]
		private static DirectorGUI _current;

		[NonSerialized]
		private static Texture dissolver;

		[NonSerialized]
		private static float dissolveCompletion;

		[NonSerialized]
		private static float letterboxCompletion;

		[NonSerialized]
		public static Color fadeColor;

		[NonSerialized]
		private static string subsText;

		[NonSerialized]
		private static Color subsColor;

		[NonSerialized]
		private static string overlayText;

		[NonSerialized]
		private static Color overlayTextColor;

		[NonSerialized]
		private static float overlayTextSize;

		[NonSerialized]
		private static TextAnchor overlayTextAnchor;

		[NonSerialized]
		private static Vector2 overlayTextPos;

		[NonSerialized]
		private static Texture overlayTexture;

		[NonSerialized]
		private static Color overlayTextureColor;

		[NonSerialized]
		private static Vector2 overlayTextureScale;

		[NonSerialized]
		private static Vector2 overlayTexturePosition;

		public static DirectorGUI current
		{
			get
			{
				return null;
			}
		}

		private static GUIStyle subsStyle { get; set; }

		private static GUIStyle overlayTextStyle { get; set; }

		public static event SubtitlesGUIDelegate OnSubtitlesGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event TextOverlayGUIDelegate OnTextOverlayGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event TextureOverlayGUIDelegate OnTextureOverlayGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event ScreenFadeGUIDelegate OnScreenFadeGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event LetterboxGUIDelegate OnLetterboxGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnGUIEnable
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnGUIDisable
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnGUIUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static void UpdateDissolve(Texture texture, float completion)
		{
		}

		public static void UpdateLetterbox(float completion)
		{
		}

		public static void UpdateFade(Color color)
		{
		}

		public static void UpdateSubtitles(string text, Color color)
		{
		}

		public static void UpdateOverlayText(string text, Color color, float size, TextAnchor anchor, Vector2 pos)
		{
		}

		public static void UpdateOverlayTexture(Texture texture, Color color, Vector2 scale, Vector2 positionOffset)
		{
		}

		private void OnGUI()
		{
		}

		private void DoDissolve()
		{
		}

		private void DoLetterbox()
		{
		}

		private void DoFade()
		{
		}

		private void DoSubs()
		{
		}

		private void DoOverlayText()
		{
		}

		private void DoOverlayTexture()
		{
		}

		private void DoRuleOfThirds()
		{
		}
	}
}
