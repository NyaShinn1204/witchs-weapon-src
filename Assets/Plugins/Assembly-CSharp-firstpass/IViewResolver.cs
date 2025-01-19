using UnityEngine;

public interface IViewResolver
{
	GameObject FindView(ViewModel model);

	GameObject FindView(string viewName);
}
