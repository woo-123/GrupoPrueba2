using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace frutosecoapp.Models
{
    [Table("t_product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("price")]
        public Decimal price { get; set; }
        
        [Column("image")]
        public String ImageName { get; set; }

        [Column("duedate")]
        public DateTime DueDate { get; set; }

        [Column("status")]
        public String Status { get; set; }
        
    }
}