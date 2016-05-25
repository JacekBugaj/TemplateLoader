using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLoader.Model
{
    public partial class SiteOwner
    {
        public SiteOwner()
        {
            Sites = new List<Site>();
        }
        [Key]
        public int SiteOwnerId { get; set; }
        public string SiteOwnerName { get; set; }
        public string SiteOwnerSurname { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}
