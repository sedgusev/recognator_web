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
        [Display(Name = "Номер")]
        public string Number { get; set; }

        [StringLength(30)]
        [Display(Name = "Марка")]
        public string Car { get; set; }

        [StringLength(10)]
        [Display(Name = "Цвет")]
        public string Color { get; set; }

        [StringLength(256)]
        [Display(Name = "Владелец")]
        public string Username { get; set; }
    }
}
