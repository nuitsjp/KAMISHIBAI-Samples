using Xamarin.Forms;

namespace StylishListViewSample.Models
{
    public class Fruit
    {
        private static int _maxId;
        public int Id { get; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Fruit()
        {
            Id = ++_maxId;
        }
    }
}
