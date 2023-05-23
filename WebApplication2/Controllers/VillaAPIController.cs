using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    [Route("/api/VillaAPI")]
    [ApiController]
    public class VillaAPIController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa {Id=1, Name="minu"},
                new Villa {Id =2 , Name =" narmadha"}
            };
            
        }
    }
}
