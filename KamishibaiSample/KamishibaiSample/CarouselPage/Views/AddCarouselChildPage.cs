using Nuits.Xamarin.Forms.Kamishibai.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample.CarouselPage.Views
{
    public class AddCarouselChildPage<T> : AddChildPage<T, ContentPage> where T : ContentPage, new()
    {
    }
}
