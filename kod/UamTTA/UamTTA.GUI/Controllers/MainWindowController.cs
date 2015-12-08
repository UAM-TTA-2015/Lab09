using UamTTA.GUI.Models;
using UamTTA.GUI.ViewModels;

namespace UamTTA.GUI.Controllers
{
	public class MainWindowController : IMainWindowController
	{
		private readonly IBudgetService _service;

		public MainWindowViewModel ViewModel { get; set; }

		public MainWindowController(IBudgetService service)
		{
			_service = service;
		}

		public void OnGetBudget()
		{
		}
	}
}