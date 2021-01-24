using AutoMapper;
using DocumnetAPI.DTOModels;
using DocumnetAPI.Models;
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
        public ActionResult<IEnumerable<DocumentReadDTO>> GetDocuments()
        {

            return Ok(_mapper.Map<IEnumerable<DocumentReadDTO>>(_repoContext.GetAllDocuments()));
        }
        [HttpGet("{id}", Name = "GetDocumentByID")]
        public ActionResult<DocumentReadDTO> GetDocumentByID(int id)
        {
            var document = _repoContext.GetDocumentByID(id);
            if (document != null) return Ok(_mapper.Map<DocumentReadDTO>(document));
            return NotFound();

        }
        [HttpPost]
        public ActionResult<DocumentReadDTO> CreateDocument(DocumentCreateDTO createDTO)
        {
            var document = _mapper.Map<Document>(createDTO);
            _repoContext.CreateDocument(document);
            _repoContext.SaveChanges();

            var documntReadModel = _mapper.Map<DocumentReadDTO>(document);

            return CreatedAtRoute(nameof(GetDocumentByID), new { id = documntReadModel.ID }, documntReadModel);


        }

        [HttpPut("{id}")]
        public ActionResult UpdateDocuemnt(int id, DocumentUpdateDTO updateDTO)
        {
            var document = _repoContext.GetDocumentByID(id);
            if (document == null) return NotFound();

            _mapper.Map(updateDTO, document);
            _repoContext.UpdateDocuemt(document);
            _repoContext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var document = _repoContext.GetDocumentByID(id);
            if (document == null) return NotFound();
            _repoContext.DeleteDocument(document);
            _repoContext.SaveChanges();

            return NoContent();
        }
    }
}
