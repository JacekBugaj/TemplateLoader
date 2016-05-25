using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLoader.Model
{
    public partial class Site
    {
        [Key]
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int CustomerId { get; set; }
        public int SiteOwnerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("SiteOwnerId")]
        public virtual SiteOwner SiteOwner { get; set; }

    }
}
