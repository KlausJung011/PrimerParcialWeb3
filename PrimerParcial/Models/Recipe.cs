using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Display(Name = "Título de la receta")]
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Instructions { get; set; }

        public int PreparationTimeMinutes { get; set; }

        public int Servings { get; set; }

        // --- Relaciones de Entity Framework Core ---

        // Clave Foránea (FK): Vincula esta receta a la categoría
        public int CategoryId { get; set; }

        // Propiedad de Navegación: El lado 'uno'
        public Category Category { get; set; }

        // Propiedad de Navegación: El lado 'muchos' para las Recetas en esta Categoría
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
