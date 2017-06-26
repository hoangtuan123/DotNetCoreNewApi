
using System;
using Base.Service.IService;
using Base.Model;
using Base.ModelView;
using Base.Model.GenericRepository;
using Base.Model.UnitOfWork;
using AutoMapper;
namespace Base.Service.Service
{
    public class NewsService : BaseCoreService<News,NewsModelView>, INewsService
    {
        public NewsService(UnitOfWork<News> unitOfWork,IMapper mapper) : base(unitOfWork,mapper)
        {

        }
    }
}