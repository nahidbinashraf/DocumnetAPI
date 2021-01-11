using DocumnetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Repository
{
    public class SqlDocumentRepo : IDocumentRepo
    {
        private readonly DocumentDBContext _context;

        public SqlDocumentRepo(DocumentDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Document> GetAllDocuments()
        {
           return  _context.Documnets.ToList();
        }

        public Document GetDocumentByID(int ID)
        {
           return _context.Documnets.FirstOrDefault(x => x.ID == ID);
        }
    }
}
