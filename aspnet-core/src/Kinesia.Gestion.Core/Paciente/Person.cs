using Abp.Domain.Entities.Auditing;

namespace Kinesia.Gestion.Paciente
{
    public class Person : FullAuditedEntity<long>
    {
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Correo { get; set; }
        public virtual string Dni { get; set; }
    }
}