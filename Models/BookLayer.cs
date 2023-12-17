using System;
namespace _4guys_bs.Models
{
	public class BookLayer
	{
        public IEnumerable<Book> GetAll()
		{
			return new List<Book>();
		}

		// public Book GetById(string IdBook)
		// {
        //     Book book = new Book()
		// 	{
        //         IdBook = 99,
		// 		Title = "",
		// 		Price = 111,
		// 		Author = "",
		// 		Description = "",
		// 		Category = "",
		// 		ImgURL = "",
		// 	};
		// 	return book;
		// }

        public void Insert(Book book)
        {
            //logic to insert a book
        }
        public void Update(Book book)
        {
            //logic to Update a book
        }
        public void Delete(string IdBook)
        {
            //logic to Delete a book
        }
    }
}

