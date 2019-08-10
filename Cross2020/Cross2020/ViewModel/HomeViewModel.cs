using Cross2020.Models;
using System.Collections.ObjectModel;

namespace Cross2020.ViewModel
{
    public class HomeViewModel
    {
        public ObservableCollection<Filme> filmes = new ObservableCollection<Filme>();
        public ObservableCollection<Filme> Filmes {
            get
            {
                return filmes;
            }
            set
            {
                filmes = value;
            }
        }

        public HomeViewModel()
        {
            Filme f = new Filme();

            f.Titulo = "Filme 1";
            f.Desc = "Desc filme 1";
            this.filmes.Add(f);

            f = new Filme();

            f.Titulo = "Filme 2";
            f.Desc = "Desc filme 2";
            this.filmes.Add(f);

            f = new Filme();

            f.Titulo = "Filme 3";
            f.Desc = "Desc filme 3";
            this.filmes.Add(f);
        }
    }
}
