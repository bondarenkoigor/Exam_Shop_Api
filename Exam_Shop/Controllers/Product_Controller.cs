using Exam_Shop.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Exam_Shop.Models;

namespace Exam_Shop.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]/")]
    public class Product_Controller : ControllerBase
    {
        ExamDbContext dbContext = new ExamDbContext();
        [HttpGet]
        [Route("AllProducts")]
        public List<Product> Get()
        {
            return dbContext.Products.ToList();
            
        }

        [HttpPost]
        [Route("addProduct")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Add()
        {
            return Ok("Product added!");
        }
    }
}
