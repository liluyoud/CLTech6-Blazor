using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTech.Core.Interfaces
{
    public interface IAuditModel
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime? DeletedDate { get; set; }
        string DeletedBy { get; set; }
    }
}
