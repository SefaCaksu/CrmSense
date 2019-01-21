using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Dto;
using Microsoft.AspNetCore.Mvc;

namespace SenseApi.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITestService _testService;

        public ValuesController(ITestService testService)
        {
            _testService = testService;
        }

        [Route("api/TestList")]
        [HttpGet]
        public List<DtoTest> TestList()
        {
            var test = _testService.TestList();
            return test;
        }

        [Route("api/Test/{id:int}")]
        [HttpGet]
        public DtoTest Test(int id)
        {
            return _testService.TestGet(id);
        }

        [Route("api/TestListAsyn")]
        [HttpGet]
        public object TestListAsyn()
        {
            var test = _testService.TestList();
            return test;
        }

        [Route("api/TestContext/{id:int}")]
        [HttpGet]
        public DtoTest TestContext(int id)
        {
            return _testService.TestContext(id);
        }
    }
}
