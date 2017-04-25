using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    


    public class ArticleViewModel
    {
        public ArticleViewModel()
        {
            this.Date = DateTime.Now;
        }


        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(200)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Съдържание")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Прикачи снимка")]
        public string Image { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Автор")]
        public string AuthorId { get; set; }

        [Display(Name ="Категория")]
        public int CategoryId { get; set; }

        [Display(Name ="Тагове")]
        public string Tags { get; set; }

        public List<Category> Categories { get; set; }

        
    }
}