using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WaterBell.Framework.Event
{
	public class EventEngine
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		private delegate void InternalEventHandler(EventBase e);

		private static EventEngine _instance;

		private static EventEngine _uiGuideInstance;

		private static EventEngine _battleGuideInstance;

		private Dictionary<int, InternalEventHandler> evtHandlerCache;

		private Dictionary<Type, InternalEventHandler> evtHandlerDict;

		public static EventEngine GetInstance()
		{
			return null;
		}

		public static EventEngine GetInstance_UIGuide()
		{
			return null;
		}

		public static EventEngine GetInstance_BattleGuide()
		{
			return null;
		}

		public static void FireEvent(EventBase e)
		{
		}

		public static void NewListener<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public static void RmListener<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public static void FireEvent_UIGuide(EventBase e)
		{
		}

		public static void NewListener_UIGuide<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public static void RmListener_UIGuide<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public void AddListener<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public void RemoveListener<T>(EventHandler<T> handler) where T : EventBase
		{
		}

		public void ClearAllListener()
		{
		}

		public void Fire(EventBase e)
		{
		}
	}
}
