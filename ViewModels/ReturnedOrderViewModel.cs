using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Capstone.ViewModels
{
    public class ReturnedOrderViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
