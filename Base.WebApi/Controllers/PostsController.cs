using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Base.Service.IService;
using Base.Model;
using Base.ModelView;
namespace Base.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private INewsService newsSerivce;
        public PostsController(INewsService newsSerivce)
        {
            this.newsSerivce = newsSerivce;
        }
        [HttpGet]
        public IEnumerable<NewsModelView> GetAll()
        {
            return newsSerivce.GetAll();
        }
    }
}
