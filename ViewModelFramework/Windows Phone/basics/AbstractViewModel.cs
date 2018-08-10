using System;
using System.Collections.Generic;
using DE.Myparcelservice.App.OSAPIInterfaces;
using System.ComponentModel;

namespace DE.Myparcelservice.App.ViewModels.Basics
{
    public abstract class AbstractViewModel<TModel> : INotifyPropertyChanged
    {
        private int _initializationProgress;

        public event PropertyChangedEventHandler PropertyChanged;


        protected internal TModel _model;

        private IAsyncTask<TModel, int, object> _asyncTask;
        private IAsyncTaskCreator _asyncTaskCreator;

        public AbstractViewModel(TModel model, IAsyncTaskCreator asyncTaskCreator)
        {
            _asyncTaskCreator = asyncTaskCreator;
            _initializationProgress = 0;
            _model = model;

            
        }
        protected void startInitialization()
{
        if (_asyncTaskCreator != null)
            {
                _asyncTask = _asyncTaskCreator.CreateAsyncTask<TModel, int, object>(GetInitializer
                    ());
                _asyncTask.Execute(_model);
            }
}

        internal virtual IAsyncDelegate<TModel, int, object> GetInitializer()
        {
            return new _IAsyncDelegate_34(this);
        }

        private sealed class _IAsyncDelegate_34 : IAsyncDelegate<TModel, int, object>
        {
            public _IAsyncDelegate_34(AbstractViewModel<TModel> _enclosing)
            {
                this._enclosing = _enclosing;
            }

            public object DoInBackground(params TModel[] tModels)
            {
                this._enclosing.InitializeAsynchronously();
                return null;
            }

            public void OnProgressUpdate(params int[] values)
            {
                this._enclosing._initializationProgress = values[0];
                this._enclosing.RaisePropertyChanged("InitializationProgress");
            }

            public void OnPostExecute(object einVoid)
            {
                this._enclosing.OnInitializationDone();
            }

            public void OnPreExecute()
            {
            }

            private readonly AbstractViewModel<TModel> _enclosing;
        }

        public virtual int GetInitializationProgress()
        {
            return _initializationProgress;
        }

        public virtual TModel GetModel()
        {
            return _model;
        }



        protected internal virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public virtual void SetModel(TModel model)
        {
            _model = model;
        }

        protected internal abstract void InitializeAsynchronously();

        protected internal virtual void UpdateInitializationProgress(int progress)
        {
            _asyncTask.PublishProgress(progress);
        }

        protected internal abstract void OnInitializationDone();

    }
}
