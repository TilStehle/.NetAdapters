
namespace DE.Myparcelservice.App.ViewModels.Basics
{
	public interface IViewModel<TModel>
	{
		void SetModel(TModel model);

		TModel GetModel();
	}
}
