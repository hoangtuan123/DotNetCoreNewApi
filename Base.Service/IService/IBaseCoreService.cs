
using System;
using Base.Service.Service;
using Base.Model;
using System.Collections.Generic;

namespace Base.Service.IService
{
    public interface IBaseCoreService<Model,ModelView>
    {
        IEnumerable<ModelView> GetAll();

        ModelView GetByID(int ID);

        bool Add(ModelView modelView);

        bool Update(ModelView modelView);

    }
}