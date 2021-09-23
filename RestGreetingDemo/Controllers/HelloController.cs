using Microsoft.AspNetCore.Mvc;

namespace RestGreetingDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase {

        [HttpGet]
        public string Get() {
            return "Hello world";
        }

        [HttpGet, Route("{name}")]
        public string Get(string name) {
            string helloString = "Hello " + name;
            return helloString;
        }

        [HttpGet, Route("{name}/{times}")]
        public string Get(string name, int times) {
            string helloString = "Hi " + name + " " + times + " times";
            return helloString;
        }

        [HttpPost]
        public void Post([FromBody] string value) {
        }

    }
}