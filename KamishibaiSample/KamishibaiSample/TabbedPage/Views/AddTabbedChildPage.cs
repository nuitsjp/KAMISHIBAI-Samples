using Xamarin.Forms;

namespace KamishibaiSample.TabbedPage.Views
{
    public class AddTabbedChildPage<T> : AddChildPage<T, Page> where T : Page, new()
    {
    }
}
