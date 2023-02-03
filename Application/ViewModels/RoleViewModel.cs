using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "權限名稱")]
        public string Name { get; set; }
    }
}