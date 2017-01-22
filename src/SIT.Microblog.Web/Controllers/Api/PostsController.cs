using Microsoft.AspNetCore.Mvc;

namespace SIT.Microblog.Web.Controllers.Api
{
    public class PostsController : Controller
    {
	    public IActionResult Get()
	    {
		    return Ok("Hello world");
	    }
    }
}