namespace FinalExam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        public int TeamID { get; set; }

        [Required]
        [Display(Name="Team")]
        [StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "GP")]
        public int? Games { get; set; }
        [Display(Name = "W")]
        public int? Wins { get; set; }
        [Display(Name = "L")]
        public int? Losses { get; set; }
        [Display(Name = "OT")]
        public int? OvertimeLosses { get; set; }
        [Display(Name = "PTS")]
        public int? Points { get; set; }

        public int DivisionID { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public virtual Division Division { get; set; }
    }
}
