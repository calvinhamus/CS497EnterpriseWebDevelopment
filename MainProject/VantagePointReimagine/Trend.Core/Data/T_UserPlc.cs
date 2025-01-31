namespace Trend.Core.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_UserPlc
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string T_UserId { get; set; }

        public int T_PlcId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual T_Plc T_Plc { get; set; }
    }
}
