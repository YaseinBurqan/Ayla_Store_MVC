using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ayla_Store_MVC.Models;

public partial class Review
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Description { get; set; }

    [Display(Name = "Entry Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DefaultValue(typeof(DateTime), "")]
    public DateTime? EntryDate { get; set; } = DateTime.Today;
}
