namespace recognator_web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
    {
        public int LicenseId { get; set; }

        [StringLength(9)]
        public string Number { get; set; }

        [StringLength(30)]
        public string Car { get; set; }

        [StringLength(10)]
        public string Color { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }
    }
}
