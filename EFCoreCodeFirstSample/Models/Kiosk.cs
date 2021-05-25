using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstSample.Models
{
    public class Kiosk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KioskId { get; set; }

        public string KioskName { get; set; }

        public long LocationId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
