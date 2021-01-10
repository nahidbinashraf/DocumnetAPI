using DocumnetAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Repository
{
    public class DocumentDBContext : DbContext
    {
        public DocumentDBContext(DbContextOptions<DocumentDBContext> options) : base(options)
        {
            
        }
        public DbSet<Document> Documnets { get; set; }
    }
}
