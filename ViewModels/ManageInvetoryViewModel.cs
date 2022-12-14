using System.ComponentModel.DataAnnotations;

namespace Capstone.ViewModels
{
    public class ManageInvetoryViewModel
    {
        [Key]
        public int Id { get; set; }
        public string BaseName { get; set; }
        public string Price { get; set; }
        public int Stocks { get; set; }
    }
}
