using Microsoft.AspNetCore.Mvc;
using Nugatory.Models;

namespace WordApi.Controllers
{
    [ApiController, Route("[controller]/word")]
    public class ApiController : ControllerBase
    {
        private DataContext _dataContext;

        public ApiController(DataContext db)
        {
            _dataContext = db;
        }
        // http get entire collection
        [HttpGet]
        public IEnumerable<WordColor> Get()
        {
            return _dataContext.WordColors;
        }
        // http get specific member of collection
        [HttpGet("{id}")]
        public WordColor Get(int id)
        {
            return _dataContext.WordColors.Find(id);
        }
    }
}
