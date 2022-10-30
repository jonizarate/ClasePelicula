using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClasePelicula
{
    internal class ClassPelicula
    {
        public string Nombre { get; set; }
        public string Director { get; set; }
        public int AnioDeLiberacion { get; set; }
        public string Genero { get; set; }
        public int Presupuesto { get; set; }

        public int Recaudacion { get; set; }
        public short DuracionEnMinutos { get; set; }
        
        
        public ClassPelicula()
        {
            Nombre = "";
            Director = "";
            AnioDeLiberacion = 0;
            Genero = "";
            Presupuesto = 0;
            Recaudacion = 0;
            DuracionEnMinutos = 0;
        }
        public ClassPelicula(string nombre, string director, int anioDeLiberacion, string genero, int presupuesto, int recaudacion, short duracionEnMinutos)
        {
            Nombre = nombre;
            Director = director;
            AnioDeLiberacion = anioDeLiberacion;
            Genero = genero;
            Presupuesto = presupuesto;
            Recaudacion = recaudacion;
            DuracionEnMinutos = duracionEnMinutos;
        }

        public bool EsAnioBisiesto()
        {
            if (AnioDeLiberacion % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EsDeTerror()
        {
            return Genero.ToLower().Contains("terror");
        }
    }
}
