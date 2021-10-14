using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudVentas
{
    public class IndexModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Conexion _context;

        public IndexModel(ConsolasExito.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Venta> Venta { get;set; }

        public async Task OnGetAsync()
        {
            Venta = await _context.Ventas.ToListAsync();
        }
    }
}
