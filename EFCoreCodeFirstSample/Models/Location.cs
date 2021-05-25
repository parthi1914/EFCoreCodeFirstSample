using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstSample.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LocationId { get; set; }

        public string LocationName { get; set; }

        public long AddressId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
