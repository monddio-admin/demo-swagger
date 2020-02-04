using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemoApp.Data;
using System.Collections.Generic;

namespace SwaggerDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DemoController : ControllerBase
    {
        /// <summary>
        /// Gets all of MyClass items.
        /// </summary>
        /// <param name="id"></param>        
        // GET: api/Demo
        [HttpGet]
        [ProducesResponseType(typeof(MyClass), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<MyClass>> Get()
        {
            return Ok(new MyClass[] { new MyClass(), new MyClass() });
        }

        /// <summary>
        /// Gets a MyClass item.
        /// </summary>
        /// <param name="id">Id of the given MyClass item</param> 
        // GET: api/Demo/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(MyClass), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MyClass> Get(int id)
        {
            return Ok(new MyClass());
        }

        /// <summary>
        /// Creates a new MyClass
        /// </summary>
        /// <param name="myClass">New entity to create</param>
        /// <returns></returns>
        // POST: api/Demo
        [HttpPost]
        [ProducesResponseType(typeof(MyClass), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MyClass> Post(MyClass myClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // Do some logics with class

            return Ok(myClass);
        }

        // PUT: api/Demo/5
        [HttpPut("{id}")]
        [ProducesResponseType( StatusCodes.Status200OK)]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
