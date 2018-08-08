
package de.myparcelservice.app.ViewModels.basics;

/**
 * @sharpen.ignore.implements
 * ignoriert das vererbende interface
 */
public interface IViewModel<TModel> extends IViewModelBase
{
	public void SetModel(TModel model);
	public TModel GetModel();
}
