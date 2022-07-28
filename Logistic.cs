namespace LogisticsApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logistic
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Sender { get; set; }

        [Required]
        [StringLength(160)]
        public string SendAddress { get; set; }

        [Required]
        [StringLength(160)]
        public string RecAddress { get; set; }

        public double Weight { get; set; }

        public int? Length { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }
    }
}
