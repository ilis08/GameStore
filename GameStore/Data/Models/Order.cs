using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Please, enter your name")]
        [StringLength(15)]
        [Required(ErrorMessage = "Length of name should be more than 1 symbol ")]
        public string Name { get; set; }
        
        [Display(Name = "Please, enter your surname")]
        [StringLength(15)]
        [Required(ErrorMessage = "Length of surname should be more than 1 symbol ")]
        public string Surname { get; set; }
        
        [Display(Name = "Please, enter your address")]
        [StringLength(15)]
        [Required(ErrorMessage = "Length of surname should be more than 5 symbol ")]
        public string Address { get; set; }
        [Display(Name = "Please, enter your phone number")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Length of phone number should be more than 10 symbol ")]
        public string Phone { get; set; }
        [Display(Name = "Please, enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
