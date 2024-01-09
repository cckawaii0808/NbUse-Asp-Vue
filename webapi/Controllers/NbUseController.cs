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
        // 在這裡返回您的 UseInfo 集合
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
