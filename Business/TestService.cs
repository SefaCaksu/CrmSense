using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Generic;
using Dto;
using Entity;
using Entity.Table;

namespace Business
{
    public class TestService : GenericRepository<Test>, ITestService
    {
        public SenseContext dc;
        public TestService(SenseContext context) : base(context)
        {
            dc = context;
        }

        public DtoTest TestGet(int id)
        {
            var testData = this.Get(id);

            DtoTest test = new DtoTest();
            test.ID = testData.ID;
            test.NAME = testData.NAME;
            test.EMAIL = testData.EMAIL;

            return test;
        }

        public List<DtoTest> TestList()
        {
            var tests = this.GetAll();

            return tests.Select(c => new DtoTest()
            {
                ID = c.ID,
                NAME = c.NAME,
                EMAIL = c.EMAIL
            }).ToList();
        }

        public async Task<List<DtoTest>> TestListAsync()
        {
            var tests = await this.GetAllAsyn();

            return tests.Select(c => new DtoTest()
            {
                ID = c.ID,
                NAME = c.NAME,
                EMAIL = c.EMAIL
            }).ToList();
        }

        public DtoTest TestContext(int id)
        {
            var testData = dc.Tests.FirstOrDefault(c=> c.ID == id);

            DtoTest test = new DtoTest();
            test.ID = testData.ID;
            test.NAME = testData.NAME;
            test.EMAIL = testData.EMAIL;

            return test;
        }
    }
}