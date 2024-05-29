using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PPAI_DSI_2024.Entidades
{
    public class Provincia
    {
        // Atributos
        private string nombre;
        private Pais pais;

        // Constructor
        public Provincia (string nombre, Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }

        // Metodos get y set
        public string Nombre { get => nombre; set => nombre = value; }
        public Pais Pais { get => pais; set => pais = value; }

        // Metodos

        public void obtenerPais(List<string> vinoParaExcel)
        {
            string nombrePais = pais.getNombre();
            vinoParaExcel.Add(nombrePais);
        }
    }
}
