public class SceneStateResolver : DefaultTypeResolver
{
	public SceneManager Context { get; set; }

	public SceneStateResolver(SceneManager context)
	{
	}

	public override object CreateInstance(string name, string identifier)
	{
		return null;
	}
}
