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

        public void CreateDocument(Document document)
        {
            if(document == null)
            {
                throw new ArgumentNullException();
            }
            _context.Add(document);
        }

        public void DeleteDocument(Document document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }
            _context.Documnets.Remove(document);
        }

        public IEnumerable<Document> GetAllDocuments()
        {
           return  _context.Documnets.ToList();
        }

        public Document GetDocumentByID(int ID)
        {
           return _context.Documnets.FirstOrDefault(x => x.ID == ID);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);

        }

        public void UpdateDocuemt(Document document)
        {
            //nothin
        }
    }
}
