using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Data
{
    public class ReturnedOrder
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }   

    }
}
