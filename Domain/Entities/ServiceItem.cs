using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill this field")]
        [Display(Name = "Our services")]
        public override string Title { get; set; }

        [Display(Name = "Short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public override string Text { get; set; }
    }
}
