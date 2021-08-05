using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFHeadPhones.Models;
using XFHeadPhones.ViewModel;
using XFHeadPhones.Views;

namespace XFHeadPhones.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Phones = new ObservableCollection<Phone>();
            Speakers = new ObservableCollection<Speaker>();
            NavigateToDetailPage = new Command<Phone>(async (model) => await ExecuteNavigateToDetailPage(model));
            GetProducts();
            GetSpeakers();
        }

        private readonly INavigation _navigation;
        public Command NavigateToDetailPage { get; }
        public ObservableCollection<Phone> Phones { get; set; }
        public ObservableCollection<Speaker> Speakers { get; set; }

        void GetProducts()
        {
            Phones.Add(new Phone()
            {
                name = "HexOhm Green",
                price = 80,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "HexOhm_Green.png"
            });

            Phones.Add(new Phone()
            {
                name = "HexOhm Red",
                price = 90,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "HexOhm_Red.png"
                
            });

            Phones.Add(new Phone()
            {
                name = "HexOhm Purple",
                price = 100,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "HexOhm_Purple.png"
            });
        }

        void GetSpeakers()
        {
            Speakers.Add(new Speaker()
            {
                description = "Liquid Lemonade",
                price = 30,
                image = "liquid_lemonade.png"
            });

            Speakers.Add(new Speaker()
            {
                description = "Liquid Mango",
                price = 40,
                image = "liquid_mango.png"
            });

            Speakers.Add(new Speaker()
            {
                description = "Liquid Colada",
                price = 50,
                image = "liquid_colada.png"
            });
        }

        private async Task ExecuteNavigateToDetailPage(Phone model)
        {
            await Navigation.PushAsync(new DetailPage(model));
        }
    }
}
