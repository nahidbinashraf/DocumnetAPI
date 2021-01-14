using DocumnetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Repository
{
    public interface IDocumentRepo
    {
        bool SaveChanges();
        IEnumerable<Document> GetAllDocuments();
        Document GetDocumentByID(int ID);
        void CreateDocument(Document document);

        void UpdateDocuemt(Document document);

    }
}
