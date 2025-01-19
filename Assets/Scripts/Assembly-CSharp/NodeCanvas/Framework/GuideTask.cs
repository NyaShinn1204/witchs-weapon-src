using NodeCanvas.GuideLessonTrees;

namespace NodeCanvas.Framework
{
	public abstract class GuideTask : ActionTask
	{
		protected GuideLessonTree lessonTree
		{
			get
			{
				return null;
			}
		}

		public virtual void InjectInfo(string[] cmdLine)
		{
		}
	}
}
