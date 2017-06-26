
using System;
using Base.Service.IService;
using Base.Model;
using System.Collections.Generic;
using AutoMapper;
using Base.Model.UnitOfWork;
namespace Base.Service.Service
{
    public class BaseCoreService<Model, ModelView> : IBaseCoreService<Model, ModelView> where Model : class
    {
        protected readonly IMapper mapper;

        protected UnitOfWork<Model> unitOfWork;
        public BaseCoreService(UnitOfWork<Model> unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public virtual bool Add(ModelView modelView)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<ModelView> GetAll()
        {
            try
            {
                var data = unitOfWork.DefaultRepository.Get();
                return mapper.Map<IEnumerable<Model>, IEnumerable<ModelView>>(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual ModelView GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(ModelView modelView)
        {
            throw new NotImplementedException();
        }
    }
}