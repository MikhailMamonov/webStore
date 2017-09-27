using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStoreApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public ApplicationUser Initiator;
        [Required(ErrorMessage = "Пожалуйста, введите свое описание затраты")]
        //description
        public ICollection<Good> Goods;
    }
}