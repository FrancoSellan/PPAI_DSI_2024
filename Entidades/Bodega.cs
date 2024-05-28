using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_2024.Entidades
{
    public class Bodega
    {
        // Atributos
        private int coordenadasUbicacion;
        private string descripcion;
        private DateTime fechaUltimaActualizacion;
        private string nombre;
        private string periodoActualizacion;
        private string historia;

        // Constructos
        public Bodega(int coordenadasUbicacion, string descripcion, DateTime fechaUltimaActualizacion, string nombre, string periodoActualizacion, string historia)
        {
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.descripcion = descripcion;
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
            this.historia = historia;
        }

        // Metodos get y set
        public int CoordenadasUbicacion { get => coordenadasUbicacion; set => coordenadasUbicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
        public string Historia { get => historia; set => historia = value; }
    }
}
