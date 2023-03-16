using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Kinesia.Gestion.Paciente
{
    public class Kinesiologos: FullAuditedEntity<long>
    {
        public virtual string MatriculaProv { get; set; }
        public virtual string MatriculaNac { get; set; }
        public virtual string Cuit { get; set; }
        public virtual DateTime Nacimiento { get; set; }
        public virtual string Categoria { get; set; }

        //Foreign Keys
        [Required]
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        public virtual long PersonId { get; set; }
    }
}
