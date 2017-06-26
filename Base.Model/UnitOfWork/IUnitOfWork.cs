using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Base.Model.GenericRepository;
namespace Base.Model.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable
    {
        IGenericRepository<T> DefaultRepository { get; }
        void Save();
    }
}
