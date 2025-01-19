using System;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.GuideLessonTrees
{
	public class GuideLessonTreeController : GraphOwner<GuideLessonTree>, IDialogueActor
	{
		string IDialogueActor.name
		{
			get
			{
				return null;
			}
		}

		Texture2D IDialogueActor.portrait
		{
			get
			{
				return null;
			}
		}

		Sprite IDialogueActor.portraitSprite
		{
			get
			{
				return null;
			}
		}

		Color IDialogueActor.dialogueColor
		{
			get
			{
				return default(Color);
			}
		}

		Vector3 IDialogueActor.dialoguePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		Transform IDialogueActor.transform
		{
			get
			{
				return null;
			}
		}

		public GuideLessonTree lessonTree
		{
			get
			{
				return null;
			}
		}

		public void StartLesson(int recID, string storyID, GuideLessonTree.RunningMode mode, int startNodeIdx = 0, Action<bool> callback = null)
		{
		}

		public void ContinueLesson(int recID, string storyID, GuideLessonTree.RunningMode mode, int state, int startNodeID = 0, Action<bool> callback = null)
		{
		}
	}
}
