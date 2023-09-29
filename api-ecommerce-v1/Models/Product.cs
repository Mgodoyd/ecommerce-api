﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_ecommerce_v1.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'titulo' es requerido.")]
        [StringLength(50)]
        [NotNumeric(ErrorMessage = "El campo 'titulo' no debe contener números.")]
        public string title { get; set; }
        public string? frontpage { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "El campo 'price' es requerido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El campo 'price' debe ser un número.")]
        public int price { get; set; }


        [Required(ErrorMessage = "El campo 'description' es requerido.")]
        [StringLength(50)]
        public string description { get; set; }

        [Required(ErrorMessage = "El campo 'content' es requerido.")]
        [StringLength(50)]
        public string content { get; set; }

        [Required(ErrorMessage = "El campo 'stock' es requerido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El campo 'stock' debe ser un número.")]
        public int stock { get; set; }

        /*[Required(ErrorMessage = "El campo 'sales' es requerido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El campo 'sales' debe ser un número.")]
        public int sales { get; set; }*/

        [Required(ErrorMessage = "El campo 'points' es requerido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El campo 'points' debe ser un número.")]
        public int points { get; set; }

        //[Required(ErrorMessage = "El campo 'state' es requerido.")]
      /* [RegularExpression(@"^\d+$", ErrorMessage = "El campo 'state' debe ser un número.")]
        public string? state { get; set; }*/

        //        [Required(ErrorMessage = "El campo 'product' es requerido.")]

        public int inventoryId { get; set; }
        [JsonIgnore]
        public Inventory? inventory { get; set; }

        public int categoryId { get; set; }

        public Category? category { get; set; }



        //public Galery? galerys { get; set; }
        public ICollection<Galery>? Galerys { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime createdDate { get; set; }

        public Product()
        {
           // state = "edition";
            createdDate = DateTime.Now; 
        }
    }
}
