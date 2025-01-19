using UnityEngine;

public class DragDropItem : UIDragDropItem
{
	public enum State
	{
		None = 0,
		OnDragDropStart = 1,
		OnDragDropRelease = 2
	}

	public State state;

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}
}
