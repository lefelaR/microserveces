using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rakheoana.Data;

namespace Rakheoana.Controllers
{
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }
    }
    
}