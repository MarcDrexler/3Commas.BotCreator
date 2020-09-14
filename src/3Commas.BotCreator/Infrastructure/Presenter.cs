using System.Windows.Forms;

namespace _3Commas.BotCreator.Views
{
    public abstract class PresenterBase<TView> where TView: IWin32Window
    {
        private TView _view;

        protected PresenterBase(TView view)
        {
            _view = view;
        }

        public TView View
        {
            get { return _view; }
            set { _view = value; }
        }
    }
}