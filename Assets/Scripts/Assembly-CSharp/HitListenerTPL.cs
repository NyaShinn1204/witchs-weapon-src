using System.Xml;

public class HitListenerTPL : BaseTPL
{
	public const int TAG_ENTITY = 1;

	public const int TAG_BLOCK = 2;

	public const int TAG_GROUND = 4;

	public int maxHitCount;

	public int tag;

	public string bone;

	public float colliderRadius;

	public bool isBind;

	public bool isRayCheck;

	public HitListenerTPL(XmlElement node)
	{
	}
}
