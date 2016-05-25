using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLoader.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Sites = new List<Site>();
            Mails = new List<Mail>();
        }
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<Mail> Mails { get; set; }

    }
}
