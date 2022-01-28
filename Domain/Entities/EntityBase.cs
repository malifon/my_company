﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Main image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
