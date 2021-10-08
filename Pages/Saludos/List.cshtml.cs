using System.Globalization;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Persistencia.AppRepositorios;
using HolaWeb.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //vector lista de cadenas - Esto es una atributo
        //private string[] saludos = {"Buenos dias", "Buenas tardes", "Buenas noches", "Hasta mañana"};
        
        //Esto es una atributo bajo una propiedad
        //public List<string> ListaSaludos {get; set;}

        private readonly IRepositorioSaludos repositorioSaludos;
        
        public IEnumerable<Saludo> Saludos {get; set;}

        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
            Saludos=repositorioSaludos.GetAll();
        }
    }
}
