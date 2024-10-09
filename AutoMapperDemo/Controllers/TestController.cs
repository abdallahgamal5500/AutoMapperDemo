using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;
        public TestController(IMapper mapper) 
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(Model2 model2)
        {
            var result = _mapper.Map<Model1>(model2);
            return Ok(result);
        }
    }
}
