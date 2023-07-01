using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Entities
{
    [Table("FurnitureTable")]
    public class Furniture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Type is mandatory")]
        [Column("Type", TypeName = "varchar(50)")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Cost is mandatory")]
        [Column("Cost", TypeName = "varchar(10)")]
        public double Cost { get; set; }
    }
}
