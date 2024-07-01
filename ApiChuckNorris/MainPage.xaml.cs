using ApiChuckNorris.Models;
using ApiChuckNorris.Services;

namespace ApiChuckNorris
{
    public partial class MainPage : ContentPage
    {
        private ConsumirApi _consumirApi;

        public ChuckNorrisChiste _chuckNorris { get; set; }

        

      


        public MainPage() 
        { 
            InitializeComponent();
            _consumirApi = new ConsumirApi();
            CargarDatos();
                                                                                                                                
        
        
        }




        private async void CargarDatos()
        {
            _chuckNorris = await _consumirApi.GetChisteAsync();
            
            
            value.Text= _chuckNorris.value;

            url.Text = _chuckNorris.url;

        }


        private void CambiarChiste(object sender, EventArgs e)
        {
            CargarDatos();
            value.Text = _chuckNorris.value;

            url.Text = _chuckNorris.url;
        }








    }

}
