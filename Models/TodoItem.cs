using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swagger.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int Rate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TickekPrice { get; set; }
    }

}
