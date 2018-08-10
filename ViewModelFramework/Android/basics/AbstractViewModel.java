package de.myparcelservice.app.ViewModels.basics;


import java.util.ArrayList;
import java.util.List;

import de.myparcelservice.app.OSAPIInterfaces.IAsyncDelegate;
import de.myparcelservice.app.OSAPIInterfaces.IAsyncTask;
import de.myparcelservice.app.OSAPIInterfaces.IAsyncTaskCreator;

/**
 * @sharpen.ignore
 * Diese Klasse wird bei der Sprachkonversion nach C# ausgelassen.
 * Grund dafür ist die in C# mit Events realisierte Anbindung an die UI
 * @param <TModel>
 */
public abstract class AbstractViewModel<TModel>
{

	private int _initializationProgress;
	private List<IViewModelObserver> _observers;
	protected TModel _model;
    private IAsyncTask<TModel,Integer,Void> _asyncTask;
    private IAsyncTaskCreator _asyncTaskCreator;

    @SuppressWarnings("unchecked")
	public AbstractViewModel(TModel model, IAsyncTaskCreator asyncTaskCreator)
	{
        _asyncTaskCreator = asyncTaskCreator;
        _initializationProgress=0;
		_model=model;
		_observers = new ArrayList<IViewModelObserver>();

		
	}
protected final void startInitialization()
{
    if(_asyncTaskCreator!=null)
    {
        _asyncTask = _asyncTaskCreator.<TModel, Integer, Void>createAsyncTask(getInitializer());
        _asyncTask.Execute(_model);
    }
}


    IAsyncDelegate<TModel,Integer,Void> getInitializer()
    {
        return new IAsyncDelegate<TModel, Integer, Void>()
        {
            @Override
            public Void doInBackground(TModel... tModels)
            {
                initializeAsynchronously();
                return null;
            }


            @Override
            public void onProgressUpdate(Integer... values)
            {
                _initializationProgress = values[0];
                RaisePropertyChanged("InitializationProgress");
            }

            @Override
            public  void onPostExecute(Void einVoid)
            {
                onInitializationDone();
            }

            @Override
            public void onPreExecute()
            {

            }

        };
    }

	public int GetInitializationProgress()
	{
		return _initializationProgress;
	}
	@Override
	public TModel GetModel()
	{
		return _model;
	}

	@Override
	public void AddObserver(IViewModelObserver newObserver)
	{
		_observers.add(newObserver);
	}

	public void removeObserver(IViewModelObserver observerToRemove)
	{
		if (_observers.contains(observerToRemove))
		{
			_observers.remove(observerToRemove);
		}
	}
	
	protected void RaisePropertyChanged(String propertyName)
	{
		for(IViewModelObserver observer: _observers)
		{
			observer.Update(this, propertyName);
		}
	}

	@Override
	public void SetModel(TModel model)
	{
		_model = model;
	}

	

	protected abstract void initializeAsynchronously();
	
	protected void updateInitializationProgress(int progress)
	{
		_asyncTask.PublishProgress(progress);
	}

	protected abstract void onInitializationDone();

}
