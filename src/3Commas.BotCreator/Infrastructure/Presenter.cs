using System.Windows.Forms;

namespace _3Commas.BotCreator.Infrastructure
{
    public abstract class PresenterBase<TView> where TView: IWin32Window
    {
        protected PresenterBase(TView view)
        {
            View = view;
        }

        protected TView View { get; }
    }
}