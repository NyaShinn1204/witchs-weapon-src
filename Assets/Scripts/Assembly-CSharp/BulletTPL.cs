using System.Xml;

public class BulletTPL : BaseTPL
{
	public bool isTrace;

	public bool lookAtTarget;

	public bool rotateSmoothly;

	public float traceAcc;

	public int minHeight;

	public int maxHeight;

	public MotionTPL motion;

	public HitListenerTPL hitTPL;

	public CompleteListenerTPL completeTPL;

	public int CacheCount;

	public BulletTPL(XmlElement node)
	{
	}

	public MotionTPL GetMotionTPL()
	{
		return null;
	}
}
