using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_.Net.Domain.Models
{
    [Table("objeto")]
    public class Objeto
    {
        [Key]
        public long id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }

        public DateTime fecha_creacion { get; set; }
    }
}
