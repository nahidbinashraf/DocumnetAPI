using AutoMapper;
using DocumnetAPI.DTOModels;
using DocumnetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumnetAPI.Profiles
{
    public class DocumentProfiles : Profile
    {
        public DocumentProfiles()
        {
            CreateMap<Document, DocumentReadDTO>();
            CreateMap<DocumentCreateDTO, Document>();
            CreateMap<DocumentUpdateDTO, Document>();
        }
    }
}
