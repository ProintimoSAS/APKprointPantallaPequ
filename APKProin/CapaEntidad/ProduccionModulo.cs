using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProduccionModulo
    {
        public int id { get; set; }
        public int CantidadPersonas { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int UnidadesFaltantes { get; set; }
        public int UnidadesFabricadas { get; set; }
        public double TiempoPrenda { get; set; }
        public int NoConformes { get; set; }
        public double PorcentajeParcial { get; set; }
        public double PorcentajeAcumulado { get; set; }
        public double UnidadesPorHora { get; set; }
        public bool Revision { get; set; }
        public bool tiempoImproductivo { get; set; }
        public string Comentarios { get; set; }
        public int TotalFabricadas { get; set; }
        public double UnidadesDejadasDeFabricar { get; set; }
        public double UnidadesPorHoraReales { get; set; }
        public double PorcentajeAcumuladoReal { get; set; }
        public int idOrdenDeProduccion { get; set; }

        /*public ProduccionModulo(int cantidadPersonas, DateTime fecha, DateTime hora, int unidadesFaltantes, int unidadesFabricadas, double tiempoPrenda, int noConformes, int porcentajeParcial, int porcentajeAcumulado, float unidadesPorHora, bool revision, int idOrdenDeProduccion)
        {
            CantidadPersonas = cantidadPersonas;
            Fecha = fecha;
            Hora = hora;
            UnidadesFaltantes = unidadesFaltantes;
            UnidadesFabricadas = unidadesFabricadas;
            TiempoPrenda = tiempoPrenda;
            NoConformes = noConformes;
            PorcentajeParcial = porcentajeParcial;
            PorcentajeAcumulado = porcentajeAcumulado;
            UnidadesPorHora = unidadesPorHora;
            Revision = revision;
            this.idOrdenDeProduccion = idOrdenDeProduccion;
        }

        public ProduccionModulo CrearProduccionModulo(int cantidadPersonas, DateTime fecha, DateTime hora, int unidadesFaltantes, int unidadesFabricadas, double tiempoPrenda, int noConformes, int porcentajeParcial, int porcentajeAcumulado, float unidadesPorHora, bool revision, int idOrdenDeProduccion)
        {
            return new ProduccionModulo(cantidadPersonas, fecha, hora, unidadesFaltantes, unidadesFabricadas, tiempoPrenda, noConformes, porcentajeParcial, porcentajeAcumulado, unidadesPorHora, revision, idOrdenDeProduccion);
        }*/
    }
}
