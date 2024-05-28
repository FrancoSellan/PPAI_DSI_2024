using PPAI_DSI_2024.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Datos
{
    public class GeneradorDeDatos
    {
        private List<Vino> listaVinos;
        private List<Bodega> bodegas;
        private List<Reseña> resenas;
        private List<RegionVitivinicola> regiones;
        private List<Provincia> provincias;
        private List<Pais> paises;
        private List<Varietal> varietales;

        public GeneradorDeDatos()
        {
            // Vinos
            Vino vino1 = new Vino(2003, Convert.ToDateTime("14/04/2005"), "imagen1", "vino1", 7, 11000);
            Vino vino2 = new Vino(2010, Convert.ToDateTime("20/08/2011"), "imagen2", "vino2", 3, 5000);
            Vino vino3 = new Vino(2015, Convert.ToDateTime("14/04/2050"), "imagen3", "vino3", 10, 20000);
            Vino vino4 = new Vino(2006, Convert.ToDateTime("14/04/2005"), "imagen4", "vino4", 9, 18000);
            Vino vino5 = new Vino(2000, Convert.ToDateTime("14/04/2005"), "imagen5", "vino5", 2, 2000);
            Vino vino6 = new Vino(2002, Convert.ToDateTime("14/04/2005"), "imagen6", "vino6", 4, 5500);
            Vino vino7 = new Vino(2019, Convert.ToDateTime("14/04/2005"), "imagen7", "vino7", 5, 6000);

            listaVinos = new List<Vino>() { vino1, vino2, vino3, vino4, vino5, vino6, vino7 };
        }
    }
}
