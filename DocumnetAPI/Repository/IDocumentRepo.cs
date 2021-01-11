using DocumnetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Repository
{
    public interface IDocumentRepo
    {
        IEnumerable<Document> GetAllDocuments();
        Document GetDocumentByID(int ID);
    }
}
