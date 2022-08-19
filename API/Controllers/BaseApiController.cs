using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //la nla2eya b postman (404 error not found)
    public class BaseApiController:ControllerBase
    {
        
    }
}