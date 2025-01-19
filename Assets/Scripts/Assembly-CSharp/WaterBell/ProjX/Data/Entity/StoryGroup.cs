using System.Collections.Generic;
using Storymod;

namespace WaterBell.ProjX.Data.Entity
{
	public class StoryGroup
	{
		private Dictionary<long, StoryNode> _separatedStoryHash;

		private List<StoryNode> _sequenceStory;

		private Dictionary<long, StoryNode> _sequenceStoryHash;

		private Dictionary<long, StoryNode> _hash;

		public List<StoryNode> _list;

		private bool unlock;

		public List<StoryNode> StoryList
		{
			get
			{
				return null;
			}
		}

		public Dictionary<long, StoryNode> SeparatedStory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<StoryNode> SequenceStory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Unlock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public StoryGroup(long sID, StoryGroupInstance sData)
		{
		}

		public List<TypeCsvStory> GetCsvStoryList()
		{
			return null;
		}

		public StoryNode GetStoryById(long id)
		{
			return null;
		}

		public void Parse(long sID, StoryGroupInstance sData)
		{
		}
	}
}
