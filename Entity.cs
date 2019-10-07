using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSS.Entities
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
    
    public abstract class EntityTimeStamp : Entity
    {
        public DateTime Created { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime Updated { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

    }

}
