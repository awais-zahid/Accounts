using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountApi.Models
{
    public class TitlePage
    {
        [Key]
        public int Id { get; set; }
        public string pageTitle { get; set; }
        public string author { get; set; }
    }
}
