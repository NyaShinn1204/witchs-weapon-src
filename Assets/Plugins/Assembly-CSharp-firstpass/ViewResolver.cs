using UnityEngine;

public class ViewResolver : IViewResolver
{
	public virtual GameObject FindView(ViewModel model)
	{
		return null;
	}

	public virtual GameObject FindView(string viewName)
	{
		return null;
	}
}
