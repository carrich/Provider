using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace vcfrestd
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       static IBookRepository repository = new BookRepository();
        public string AddNewBook(Book item)
        {
            Book newBook = repository.AddNewBook(item);
            return "Bookid" + newBook.BookId;
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteBook(int.Parse(id));
            if (deleted)
            {
                return "delete success";
            }
            else
            {
                return " not delete";
            }
        }

        

        public List<Book> GetAllBooks()
        {
            return repository.GetAllBooks();
        }

        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string UpdateBook(Book book)
        {
            bool update = repository.UpdateBook(book);
            if (update==true)
            {
                return "ok";
            }
            else
            {
                return "Please choise again";
            }
           
        }
    }
}
