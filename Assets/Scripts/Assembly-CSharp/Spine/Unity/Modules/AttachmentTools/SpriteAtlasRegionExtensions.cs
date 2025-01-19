using UnityEngine;

namespace Spine.Unity.Modules.AttachmentTools
{
	public static class SpriteAtlasRegionExtensions
	{
		internal const TextureFormat SpineTextureFormat = TextureFormat.RGBA32;

		internal const bool UseMipMaps = false;

		internal const float DefaultScale = 0.01f;

		public static AtlasRegion ToAtlasRegion(this Texture2D t, Material materialPropertySource, float scale = 0.01f)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegion(this Texture2D t, Shader shader, float scale = 0.01f, Material materialPropertySource = null)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null)
		{
			return null;
		}

		public static AtlasPage ToSpineAtlasPage(this Material m)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegion(this Sprite s, AtlasPage page)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegion(this Sprite s, Material material)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null)
		{
			return null;
		}

		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		internal static AtlasRegion ToAtlasRegion(this Sprite s, bool isolatedTexture = false)
		{
			return null;
		}

		public static Skin GetRepackedSkin(this Skin o, string newName, Material materialPropertySource, out Material m, out Texture2D t, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			m = null;
			t = null;
			return null;
		}

		public static Skin GetRepackedSkin(this Skin o, string newName, Shader shader, out Material m, out Texture2D t, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null)
		{
			m = null;
			t = null;
			return null;
		}

		public static Sprite ToSprite(this AtlasRegion ar, float pixelsPerUnit = 100f)
		{
			return null;
		}

		public static Texture2D ToTexture(this AtlasRegion ar, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		private static Texture2D ToTexture(this Sprite s, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		private static Texture2D GetClone(this Texture2D t, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		private static bool IsRenderable(Attachment a)
		{
			return false;
		}

		private static Rect SpineUnityFlipRect(this Rect rect, int textureHeight)
		{
			return default(Rect);
		}

		private static Rect GetUnityRect(this AtlasRegion region)
		{
			return default(Rect);
		}

		private static Rect GetUnityRect(this AtlasRegion region, int textureHeight)
		{
			return default(Rect);
		}

		private static Rect GetSpineAtlasRect(this AtlasRegion region, bool includeRotate = true)
		{
			return default(Rect);
		}

		private static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight)
		{
			return default(Rect);
		}

		private static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight)
		{
			return default(Rect);
		}

		private static AtlasRegion UVRectToAtlasRegion(Rect uvRect, string name, AtlasPage page, float offsetX, float offsetY, bool rotate)
		{
			return null;
		}

		private static AtlasRegion GetAtlasRegion(this Attachment a)
		{
			return null;
		}

		private static Texture2D GetMainTexture(this AtlasRegion region)
		{
			return null;
		}

		private static void ApplyPMA(this Texture2D texture, bool applyImmediately = true)
		{
		}

		private static float InverseLerp(float a, float b, float value)
		{
			return 0f;
		}
	}
}
