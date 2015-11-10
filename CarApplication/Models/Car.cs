namespace CarApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("Car")]
    public partial class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Make Name")]
        public string make_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Model Name")]
        public string model_name { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [CheckDateRangeAttribute()]
        [Display(Name = "Registration Date")]
        public DateTime registration_date { get; set; }

        [StringLength(50)]
        [Display(Name = "Color")]
        public string body_color { get; set; }

        [Range(1, 5000)]
        [Display(Name = "Engine Capacity")]
        public int? engine_capacity { get; set; }

        [Range(1, 10)]
        [Display(Name = "Number of Doors")]
        public int? doors_number { get; set; }

        [StringLength(50)]
        [Display(Name = "Image")]
        public string image_url { get; set; }
    }
}

