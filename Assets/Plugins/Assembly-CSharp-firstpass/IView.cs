using System;

public interface IView : IViewModelObserver
{
	ViewModel ViewModelObject { get; }

	Type ViewModelType { get; }

	string ViewName { get; set; }
}
