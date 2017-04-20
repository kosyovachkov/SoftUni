using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Article
    {
        public Article()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(200)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } 

        [Required]
        [Display(Name = "Съдържание")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        [Display(Name = "Автор")]
        public virtual ApplicationUser Author { get; set; }
    }



   
}