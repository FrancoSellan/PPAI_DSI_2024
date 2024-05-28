using PPAI_DSI_2024.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Reseña
    {
        // Atributos
        private string comentario;
        private bool essPremium;
        private DateTime fechaReseña;
        private int puntaje;
        private Vino vino;

        // Constructor
        public Reseña(string comentario, bool essPremium, DateTime fechaReseña, int puntaje, Vino vino)
        {
            this.comentario = comentario;
            this.essPremium = essPremium;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
            this.vino = vino;
            
            
        }

        // Metodos get y set
        public string Comentario { get => comentario; set => comentario = value; }
        public bool EsPremium { get => essPremium; set => essPremium = value; }
        public DateTime FechaReseña { get => fechaReseña; set => fechaReseña = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public Vino Vino { get => vino; set => vino = value; }

        // Metodos
        //public bool sosDePeriodo()
        //{
        //    if (gestor.FechaDesde < fechaReseña && fechaReseña < gestor.FechaHasta)
        //    {
        //        return true;
        //    } else
        //    {
        //        return false;
        //    }
        //} 

        public bool esPremium()
        {
            if (essPremium)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
