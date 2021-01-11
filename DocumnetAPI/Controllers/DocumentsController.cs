using AutoMapper;
using DocumnetAPI.DTOModels;
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
        private readonly IMapper _mapper;

        public DocumentsController(IDocumentRepo documentRepo, IMapper mapper)
        {
            _repoContext = documentRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<DocumentDTO>> GetDocuments()
        {
          
            return Ok(_mapper.Map<IEnumerable<DocumentDTO>>(_repoContext.GetAllDocuments()));
        }
        [HttpGet("{id}")]
        public ActionResult <DocumentDTO> GetDocumentByID(int id)
        {
            var document = _repoContext.GetDocumentByID(id);
            if (document != null) return _mapper.Map<DocumentDTO>(document);            
            return NotFound();

        }
    }
}
