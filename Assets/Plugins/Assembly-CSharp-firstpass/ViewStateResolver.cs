public class ViewStateResolver : DefaultTypeResolver
{
	public SceneManager Context { get; set; }

	public ViewStateResolver(SceneManager context)
	{
	}

	public override object CreateInstance(string name, string identifier)
	{
		return null;
	}
}
