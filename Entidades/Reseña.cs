using PPAI_DSI_2024.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Reseña
    {
        // Atributos
        private string comentario;
        private bool esPremium;
        private DateTime fechaReseña;
        private int puntaje;
        private Vino vino;
        private GeneradorDeDatos generadorDatos;
        

        // Constructor
        public Reseña(string comentario, bool esPremium, DateTime fechaReseña, int puntaje, Vino vino)
        {
            this.comentario = comentario;
            this.esPremium = esPremium;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
        }

        // Metodos get y set
        public string Comentario { get => comentario; set => comentario = value; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
        public DateTime FechaReseña { get => fechaReseña; set => fechaReseña = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public Vino Vino { get => vino; set => vino = value; }

        // Metodos

        public bool SosDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde < fechaReseña && fechaReseña < fechaHasta)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool essPremium()
        {
            if (esPremium)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
