using DocumnetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Repository
{
    public class MockDocumentRepo : IDocumentRepo
    {
        public List<Document> _documents = new List<Document>()
        {
            new Document{ ID=1, HowTo="Comment", LineNo="1", Platform="SQL"},
            new Document{ ID=2, HowTo="Push in githud", LineNo="2", Platform="Git"},
            new Document{ ID=3, HowTo="Statrup method", LineNo="5", Platform="Core"},
            new Document{ ID=4, HowTo="Main method", LineNo="4", Platform="C#"},
        };



        public IEnumerable<Document> GetAllDocuments()
        {
            return _documents.ToList();
        }
        public Document GetDocumentByID(int ID)
        {
            return _documents.Where(x => x.ID == ID).FirstOrDefault();
        }

     
    }
}
