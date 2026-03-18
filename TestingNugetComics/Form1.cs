using MarvelComicsMMT.Models;
using MarvelComicsMMT.Services;

namespace TestingNugetComics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = this.txtBusqueda.Text;
            ServiceComics service = new ServiceComics();
            ComicsList comics = await service.GetComicsAsync(query);
            lstComics.Items.Clear();
            foreach (Comic c in comics.Comics)
            {
                lstComics.Items.Add(c.Titulo);
            }
        }
    }
}
