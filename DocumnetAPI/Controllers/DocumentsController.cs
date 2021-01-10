using DocumnetAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentRepo _repoContext;

        public DocumentsController(IDocumentRepo documentRepo)
        {
            _repoContext = documentRepo;
        }
        [HttpGet]
        public ActionResult GetDocuments()
        {
            return Ok(_repoContext.GetDocuments());
        }
        [HttpGet("{id}")]
        public ActionResult GetDocumentByID(int id)
        {
            return Ok(_repoContext.GetDocumentByID(id));

        }
    }
}
