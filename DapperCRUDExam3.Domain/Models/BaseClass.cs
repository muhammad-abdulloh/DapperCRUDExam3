using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExam3.Domain.Models
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
