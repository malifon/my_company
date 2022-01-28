using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Title of page")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Zawartość strony")]
        public override string Text { get; set; } = "Treść wypełnia administrator";
    }
}
