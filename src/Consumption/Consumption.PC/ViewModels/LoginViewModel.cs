using Consumption.ViewModel;
using Consumption.ViewModel.Interfaces;
using MaterialDesignThemes.Wpf;
using Prism.Ioc;

namespace Consumption.PC.ViewModels
{
    public class LoginViewModel : LoginBaseViewModel
    {
        public LoginViewModel(IUserRepository repository, IContainerProvider containerProvider)
            : base(repository, containerProvider)
        {
            SnackbarMessage = new SnackbarMessageQueue();
        }

        private SnackbarMessageQueue snackbarMessageQueue;

        public SnackbarMessageQueue SnackbarMessage
        {
            get { return snackbarMessageQueue; }
            set { snackbarMessageQueue = value; RaisePropertyChanged(); }
        }

        public override void SnackBar(string msg) => SnackbarMessage.Enqueue(msg);
    }
}