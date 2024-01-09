using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class NbUseController : ControllerBase
{
  
    private readonly ILogger<NbUseController> _logger;
    public NbUseController(ILogger<NbUseController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUseInfo")]
    public IEnumerable<UseInfo> Get()
    {
        // �b�o�̪�^�z�� UseInfo ���X
        List<UseInfo> useInfoList = new List<UseInfo>
            {
                new UseInfo
                {
                    UserName = "John Doe",
                    DateTime = DateTime.Now
                },               
            };
        return useInfoList;
    }
}
