using ASP_NET_Core_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private static List<Category> categories = new List<Category>() { 
            new Category(){Id=0,Name="Sachira",ImageUrl="sachira.png"},
            new Category(){Id=1,Name="Madhushan",ImageUrl="madhushan.png"}
        };


        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        [HttpPost]
        public void Post([FromBody]Category category)
        {
            categories.Add(category);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody]Category category)
        {
            categories[id] = category;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            categories.RemoveAt(id);
        }
    }
}
