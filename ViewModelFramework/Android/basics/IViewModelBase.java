
package de.myparcelservice.app.ViewModels.basics;


public interface IViewModelBase
{
	public void AddObserver(IViewModelObserver observer);
	public void removeObserver(IViewModelObserver observer);

}
