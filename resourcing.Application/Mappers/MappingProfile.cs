using AutoMapper;
using Resourcing.Application.Models;
using Resourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Job, JobDto>();
            CreateMap<JobDto, Job>();
        }
    }
}
