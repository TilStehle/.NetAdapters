package de.myparcelservice.app.ViewModels.basics;
/**
 * @sharpen.ignore
 * Diese Klasse wird bei der Sprachkonversion nach C# ausgelassen.
 * Grund dafür ist die in C# mit Events realisierte Anbindung an die UI
 */
public interface IViewModelObserver
{
	public void Update(IViewModelBase viewModel, String propertyName);
}
