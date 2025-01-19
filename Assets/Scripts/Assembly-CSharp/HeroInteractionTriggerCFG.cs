using System;
using System.Collections.Generic;

[Serializable]
public class HeroInteractionTriggerCFG
{
	public enum GestureSequenceTypes
	{
		None = 0,
		Once = 1000,
		Sequence = 2000,
		Mult = 3000
	}

	public long id;

	public GestureSequenceTypes gestureSequenceType;

	public string desc;

	public string anim;

	public string sound;

	public int clickCount;

	public GestureResult.GestureTypes gestureType;

	public GestureResult.SwipeDirectionTypes swipeDirection;

	public List<string> clickColls;

	public override string ToString()
	{
		return null;
	}
}
