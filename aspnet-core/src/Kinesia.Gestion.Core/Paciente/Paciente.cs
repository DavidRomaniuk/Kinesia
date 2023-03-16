using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kinesia.Gestion.Paciente
{
    public class Paciente : FullAuditedEntity<long>
    {
        public virtual string Pagina { get; set; }
        public virtual string Cuit { get; set; }
        public virtual string Nota { get; set; }
        public virtual int Saldo { get; set; }

        //Foreign Keys
        [Required]
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        public virtual long PersonId { get; set; }
    }
}