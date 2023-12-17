using System;

namespace _4guys_bs.Models
{
	public class Book
	{
		public int IdBook { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string ImgURL { get; set; }

		public Book(int IdBook, string Title, string Author, decimal Price, string Description, string Category, string ImgURL)
		{
			this.IdBook = IdBook;
			this.Title = Title;
			this.Author = Author;
			this.Price = Price;
			this.Description = Description;
			this.Category = Category;
			this.ImgURL = ImgURL;

		}

        // public Book()
        // {
		// 	string book = $"{IdBook}, {Title}, {Author}, ${Price}, {Description}, {Category}, {ImgURL}";
        // }
    }
}

