using System;
using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity.Example
{
	internal class ConsoleBase : MonoBehaviour
	{
		private const int DpiScalingFactor = 160;

		private static Stack<string> menuStack;

		private string status;

		private string lastResponse;

		private Vector2 scrollPosition;

		private float? scaleFactor;

		private GUIStyle textStyle;

		private GUIStyle buttonStyle;

		private GUIStyle textInputStyle;

		private GUIStyle labelStyle;

		protected static int ButtonHeight
		{
			get
			{
				return 0;
			}
		}

		protected static int MainWindowWidth
		{
			get
			{
				return 0;
			}
		}

		protected static int MainWindowFullWidth
		{
			get
			{
				return 0;
			}
		}

		protected static int MarginFix
		{
			get
			{
				return 0;
			}
		}

		protected static Stack<string> MenuStack
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected string Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Texture2D LastResponseTexture { get; set; }

		protected string LastResponse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Vector2 ScrollPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		protected float ScaleFactor
		{
			get
			{
				return 0f;
			}
		}

		protected int FontSize
		{
			get
			{
				return 0;
			}
		}

		protected GUIStyle TextStyle
		{
			get
			{
				return null;
			}
		}

		protected GUIStyle ButtonStyle
		{
			get
			{
				return null;
			}
		}

		protected GUIStyle TextInputStyle
		{
			get
			{
				return null;
			}
		}

		protected GUIStyle LabelStyle
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected bool Button(string label)
		{
			return false;
		}

		protected void LabelAndTextField(string label, ref string text)
		{
		}

		protected bool IsHorizontalLayout()
		{
			return false;
		}

		protected void SwitchMenu(Type menuClass)
		{
		}

		protected void GoBack()
		{
		}
	}
}
