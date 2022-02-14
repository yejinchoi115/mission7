using System;
using System.Linq;

namespace m7.Models
{
    public interface IBookstoreRepository
    {
       IQueryable<Book> Books { get; }
    }
}
