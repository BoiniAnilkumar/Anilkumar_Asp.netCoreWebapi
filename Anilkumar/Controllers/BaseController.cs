using Microsoft.AspNetCore.Http;    
using Microsoft.AspNetCore.Mvc;
using BALLib.Common;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult Success<T>(T data, string message = "Request successful")
        {
            var response = ApiResponse<T>.SuccessResponse(data, message);
            return Ok(response);
        }
        protected IActionResult Failure(string message, List<string>? errors = null)
        {
            var response = ApiResponse<object>.FailureResponse(message, errors);
            return BadRequest(response);
        }
        protected IActionResult NotFoundResponse(string message)
        {
            var response = ApiResponse<object>.FailureResponse(message);
            return NotFound(response);
        }
    }
}
