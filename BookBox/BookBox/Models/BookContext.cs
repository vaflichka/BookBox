﻿

namespace BookBox.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        //public DbSet<Purchase> Purchases { get; set; }
       
    }
    
}
