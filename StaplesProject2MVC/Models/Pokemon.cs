using System.ComponentModel.DataAnnotations;

namespace StaplesProject2MVC.Models
{
    public class Pokemon
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? Hp {  get; set; }
        public int? Attack { get; set; }
        [Required]
        public int? Defense { get; set; }
        [Required]
        public int? SpAttack { get; set; }
        [Required]
        public int? SpDefense { get; set; }
        [Required]
        public int? Speed { get; set; }
    }
}
