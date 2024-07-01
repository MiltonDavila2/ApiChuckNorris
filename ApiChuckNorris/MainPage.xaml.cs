using ApiChuckNorris.Models;
using ApiChuckNorris.Services;

namespace ApiChuckNorris
{
    public partial class MainPage : ContentPage
    {
        private ConsumirApi _consumirApi;

        public ChuckNorrisChiste _chuckNorris { get; set; }

        private List<ChuckNorrisChiste> _lista = null;

        public string url { get; set; } = null;

        public string value { get; set; }= null;


        public MainPage() 
        { 
            InitializeComponent();
            _consumirApi = new ConsumirApi();
            CargarDatos();
                                                                                                                                
        
        
        }




        private async void CargarDatos()
        {
            _chuckNorris = await _consumirApi.GetChisteAsync();
            
            
            


        }


        


        

    }

}
