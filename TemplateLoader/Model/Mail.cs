using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLoader.Model
{
    public partial class Mail
    {

        [Key]
        public int MailId { get; set; }
        public int CustomerId { get; set; }
        public bool IsBackup { get; set; }
        public bool IsBackupCc { get; set; }
        public bool IsBackupOra { get; set; }
        public bool IsOutage { get; set; }
        public bool IsOutageCc { get; set; }
        public bool IsSiteOwner { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}
