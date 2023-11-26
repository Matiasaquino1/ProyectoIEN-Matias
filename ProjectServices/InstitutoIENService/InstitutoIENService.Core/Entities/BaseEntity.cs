using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoIENService.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
