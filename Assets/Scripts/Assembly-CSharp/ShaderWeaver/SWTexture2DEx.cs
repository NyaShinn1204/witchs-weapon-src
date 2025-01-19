using System;
using UnityEngine;

namespace ShaderWeaver
{
	[Serializable]
	public class SWTexture2DEx
	{
		protected Texture2D texture;

		[SerializeField]
		protected int sf_width;

		[SerializeField]
		protected int sf_height;

		[SerializeField]
		private TextureFormat sf_format;

		[SerializeField]
		protected bool sf_mipmap;

		[SerializeField]
		protected bool sf_linear;

		[SerializeField]
		protected Color[] sf_colorBuffer;

		public Texture2D Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FilterMode filterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public int width
		{
			get
			{
				return 0;
			}
		}

		public int height
		{
			get
			{
				return 0;
			}
		}

		public TextureFormat format
		{
			get
			{
				return default(TextureFormat);
			}
		}

		public bool IsNull
		{
			get
			{
				return false;
			}
		}

		public SWTexture2DEx(int _width, int _height, TextureFormat _format = TextureFormat.ARGB32, bool _mipmap = false, bool _linear = true)
		{
		}

		public SWTexture2DEx(Texture2D tex)
		{
		}

		protected void CreateFromTex(Texture2D tex)
		{
		}

		public void SetPixels(Color[] cs)
		{
		}

		public Color[] GetPixels()
		{
			return null;
		}

		public void Apply()
		{
		}

		public byte[] EncodeToPNG()
		{
			return null;
		}

		public byte[] EncodeToJPG()
		{
			return null;
		}
	}
}
