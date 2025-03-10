﻿using System.ComponentModel.DataAnnotations;

namespace polyglot.Models
{
    public class Word
    {
        public int Id { get; set; }
        [Required]
        [Display]
        public string WordFr { get; set; } = string.Empty;
        public string? WordEn { get; set; } = string.Empty;
        public string? WordEs { get; set; } = string.Empty;
    }
}
