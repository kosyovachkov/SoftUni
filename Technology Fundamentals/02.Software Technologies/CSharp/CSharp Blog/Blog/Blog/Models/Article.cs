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

        private ICollection<Tag> tags;

        public Article()
        {
            this.Date = DateTime.Now;
            this.tags = new HashSet<Tag>();
        }

        public Article(string authorId, string title, string content, string image, int categoryId)
        {
            this.AuthorId = authorId;
            this.Title = title;
            this.Content = content;
            this.Image = image;
            this.CatgoryId = categoryId;
            this.Date = DateTime.Now;
            this.tags = new HashSet<Tag>();
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

        [Display(Name = "Прикачи снимка")]
        public string Image { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        [Display(Name = "Автор")]
        public virtual ApplicationUser Author { get; set; }


        [ForeignKey("Category")]
        public int CatgoryId { get; set; }

        [Display(Name = "Категория")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
    }




}