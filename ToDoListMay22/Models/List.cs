using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoListMay22.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        public string ListName { get; set; }

        public virtual ICollection<Item> Item { get; set; }

    }
}