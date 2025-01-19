using System;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class Section
	{
		public static readonly Color DEFAULT_COLOR;

		[SerializeField]
		private string _UID;

		[SerializeField]
		private string _name;

		[SerializeField]
		private float _time;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private bool _colorizeBackground;

		public string UID
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool colorizeBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Section(string name, float time)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
