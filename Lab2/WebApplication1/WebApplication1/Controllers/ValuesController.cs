using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 20},
            new Student { Id = 2, Name = "Maria", Age = 19},
            new Student { Id = 4, Name = "Vlad", Age = 22},
            new Student { Id = 5, Name = "Florin", Age = 25},
            new Student { Id = 3, Name = "Marian", Age = 23}
        };

        [HttpGet]
        public List<Student> getAllOrdered()
        {
            return students.OrderBy(s => s.Id).ToList();
        }

        [HttpDelete]
        public List<Student> DeleteById(int ID)
        {
            students.RemoveAll(students => students.Id == ID);
            return students;
        }
    }
}
