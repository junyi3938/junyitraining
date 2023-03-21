using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
	//user2 modifying the code
	//add sub catalog name
    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
        public string? CatalogName { get; set; }
<<<<<<< HEAD
	//user 2 updated
=======
	//testing user3 modify
	//user 2 modify again jun yi
>>>>>>> 2cc39ae3706b8c2c4b9fea1b88707479b6aa20f5
        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
