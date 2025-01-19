using System;
using System.Collections.Generic;

namespace Spine
{
	internal class EventQueue
	{
		private struct EventQueueEntry
		{
			public EventType type;

			public TrackEntry entry;

			public Event e;

			public EventQueueEntry(EventType eventType, TrackEntry trackEntry, Event e = null)
			{
				type = default(EventType);
				entry = null;
				this.e = null;
			}
		}

		private enum EventType
		{
			Start = 0,
			Interrupt = 1,
			End = 2,
			Dispose = 3,
			Complete = 4,
			Event = 5
		}

		private readonly List<EventQueueEntry> eventQueueEntries;

		public bool drainDisabled;

		private readonly AnimationState state;

		private readonly Pool<TrackEntry> trackEntryPool;

		public event Action AnimationsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public EventQueue(AnimationState state, Action HandleAnimationsChanged, Pool<TrackEntry> trackEntryPool)
		{
		}

		public void Start(TrackEntry entry)
		{
		}

		public void Interrupt(TrackEntry entry)
		{
		}

		public void End(TrackEntry entry)
		{
		}

		public void Dispose(TrackEntry entry)
		{
		}

		public void Complete(TrackEntry entry)
		{
		}

		public void Event(TrackEntry entry, Event e)
		{
		}

		public void Drain()
		{
		}

		public void Clear()
		{
		}
	}
}
