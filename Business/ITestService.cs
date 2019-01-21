using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Generic;
using Dto;
using Entity.Table;

namespace Business{
    public interface ITestService
    {
        DtoTest TestGet(int id);
        List<DtoTest> TestList();
        Task<List<DtoTest>> TestListAsync();
        DtoTest TestContext(int id);
    }
}