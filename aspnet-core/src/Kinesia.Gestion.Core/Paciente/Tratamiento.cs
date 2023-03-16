using System;

namespace Kinesia.Gestion.Paciente
{
    public class Tratamiento
    {
        public virtual string ObraSocial { get; set; }
        public virtual int Sesiones { get; set; }
        public virtual DateTime PrimeraSesion { get; set; }
        public virtual int Faltas { get; set; }
        public virtual string Kinesiologo { get; set; } //TODO: Deberia apuntar al kinesiologo
        public virtual string Diagnostico { get; set; }
        public virtual string Archivos { get; set; } //Deberian ser archivos
    }
}
