﻿using System.ComponentModel.DataAnnotations;

namespace VillaApi.Dtos
{
    public class VillaNumberDto
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
        [Required]
        public int VillaId { get; set; }
        public VillaDto Villa { get; set; }
    }
}
