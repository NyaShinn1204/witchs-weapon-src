using System;
using UnityEngine;

namespace ParadoxNotion.Services
{
	public class MonoManager : MonoBehaviour
	{
		public enum UpdateMode
		{
			Auto = 0,
			Manual = 1
		}

		private static bool isQuiting;

		private static MonoManager _current;

		public static UpdateMode updateMode
		{
			get
			{
				return default(UpdateMode);
			}
			set
			{
			}
		}

		public static MonoManager current
		{
			get
			{
				return null;
			}
		}

		public event Action onUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action onLateUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action onFixedUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action onGUI
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action onApplicationQuit
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<bool> onApplicationPause
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void Create()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool isPause)
		{
		}

		private void Awake()
		{
		}

		public void Update()
		{
		}

		public void LateUpdate()
		{
		}

		public void FixedUpdate()
		{
		}

		public void OnGUI()
		{
		}
	}
}
