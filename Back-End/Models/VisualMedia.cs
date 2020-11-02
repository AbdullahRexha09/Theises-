using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPi.models
{
    public class VisualMedia
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id {get;set;}
        [Column("category")]
        public string Category {get;set;}
        [Column("caption")]
        public string Caption {get;set;}
    }
}