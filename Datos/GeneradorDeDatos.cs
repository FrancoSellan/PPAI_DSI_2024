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
            // Regiones
            RegionVitivinicola region1 = new RegionVitivinicola("descripcion1", "region1");
            RegionVitivinicola region2 = new RegionVitivinicola("descripcion2", "region2");
            RegionVitivinicola region3 = new RegionVitivinicola("descripcion3", "region3");
            RegionVitivinicola region4 = new RegionVitivinicola("descripcion4", "region4");
            RegionVitivinicola region5 = new RegionVitivinicola("descripcion5", "region5");

            regiones = new List<RegionVitivinicola>() { region1, region2, region3, region4, region5 };


            // Bodegas
            Bodega bodega1 = new Bodega("40.7128,-73.5000", "descripcion1", Convert.ToDateTime("20/09/2020"), "bodega1", "20/09/2019 - 20/09/2020", "historia1", region3);
            Bodega bodega2 = new Bodega("40.7128,-73.5000", "descripcion2", Convert.ToDateTime("20/09/2020"), "bodega1", "20/09/2019 - 20/09/2020", "historia2", region2);
            Bodega bodega3 = new Bodega("40.7128,-73.5000", "descripcion3", Convert.ToDateTime("20/09/2020"), "bodega1", "20/09/2019 - 20/09/2020", "historia3", region1);
            Bodega bodega4 = new Bodega("40.7128,-73.5000", "descripcion4", Convert.ToDateTime("20/09/2020"), "bodega1", "20/09/2019 - 20/09/2020", "historia4", region4);
            Bodega bodega5 = new Bodega("40.7128,-73.5000", "descripcion5", Convert.ToDateTime("20/09/2020"), "bodega1", "20/09/2019 - 20/09/2020", "historia5", region5);

            bodegas = new List<Bodega>() { bodega1, bodega2, bodega3, bodega4, bodega5 };

            // Varietal
            Varietal varietal1 = new Varietal("descripcion1", 40);
            Varietal varietal2 = new Varietal("descripcion2", 62);
            Varietal varietal3 = new Varietal("descripcion3", 88);
            Varietal varietal4 = new Varietal("descripcion4", 11);

            varietales = new List<Varietal>() { varietal1, varietal2, varietal3, varietal4 };

            // Pais
            Pais pais1 = new Pais("Argentina");

            paises = new List<Pais>() { pais1 };

            // Provincias
            Provincia provincia1 = new Provincia("Cordoba", pais1);
            Provincia provincia2 = new Provincia("Mendoza", pais1);
            Provincia provincia3 = new Provincia("Santa cruz", pais1);

            provincias = new List<Provincia>() { provincia1, provincia2, provincia3 };

            // Vinos
            Vino vino1 = new Vino(2003, Convert.ToDateTime("14/04/2005"), "imagen1", "vino1", 7, 11000);
            Vino vino2 = new Vino(2010, Convert.ToDateTime("20/08/2011"), "imagen2", "vino2", 3, 5000);
            Vino vino3 = new Vino(2015, Convert.ToDateTime("14/04/2050"), "imagen3", "vino3", 10, 20000);
            Vino vino4 = new Vino(2006, Convert.ToDateTime("14/04/2005"), "imagen4", "vino4", 9, 18000);
            Vino vino5 = new Vino(2000, Convert.ToDateTime("14/04/2005"), "imagen5", "vino5", 2, 2000);
            Vino vino6 = new Vino(2002, Convert.ToDateTime("14/04/2005"), "imagen6", "vino6", 4, 5500);
            Vino vino7 = new Vino(2019, Convert.ToDateTime("14/04/2005"), "imagen7", "vino7", 5, 6000);

            listaVinos = new List<Vino>() { vino1, vino2, vino3, vino4, vino5, vino6, vino7 };

            // Reseñas
            Reseña resena1 = new Reseña("Excelente vino", true, Convert.ToDateTime("07/07/2018"), 9, vino3);
            Reseña resena2 = new Reseña("Buen vino", true, Convert.ToDateTime("20/10/2020"), 7, vino4);
            Reseña resena3 = new Reseña("Mal vino", false, Convert.ToDateTime("01/01/2019"), 3, vino2);
            Reseña resena4 = new Reseña("Muy mal vino", false, Convert.ToDateTime("15/11/2016"), 1, vino5);
            Reseña resena5 = new Reseña("Excelente vino", true, Convert.ToDateTime("09/09/2022"), 10, vino3);
            Reseña resena6 = new Reseña("Malisimo el vino", true, Convert.ToDateTime("27/04/2024"), 3, vino5);
            Reseña resena7 = new Reseña("Un vino colosal", false, Convert.ToDateTime("17/07/2023"), 8, vino3);
            Reseña resena8 = new Reseña("Buen vino", false, Convert.ToDateTime("20/03/2023"), 9, vino4);
            Reseña resena9 = new Reseña("Excelente vino", true, Convert.ToDateTime("31/12/2021"), 9, vino3);
            Reseña resena10 = new Reseña("Mal vino", true, Convert.ToDateTime("24/06/2023"), 4, vino7);

            resenas = new List<Reseña>() { resena1, resena2, resena3, resena4, resena5, resena6, resena7, resena8, resena9, resena10 };
        }

        public List<Vino> getVinos()
        {
            return listaVinos;
        }

        public List<Reseña> getResena()
        {
            return resenas;
        }

        public List<RegionVitivinicola> getRegiones()
        {
            return regiones;
        }

        public List<Bodega> getBodega()
        {
            return bodegas;
        }

        public List<Varietal> getVarietal()
        {
            return varietales;
        }

        public List<Pais> getPaises()
        {
            return paises;
        }

        public List<Provincia> getProvincias()
        {
            return provincias;
        }
    }
}
