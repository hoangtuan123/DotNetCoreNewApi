using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Base.Model.GenericRepository;
namespace Base.Model.UnitOfWork
{
    public class UnitOfWork<T> where T : class // : IUnitOfWork<T>
    {
        private MyContext myContext = null;
        private bool disposed = false;

        public GenericRepository<T> defaultRepository;

        public UnitOfWork(GenericRepository<T> defaultRepository)
        {
            this.myContext = new MyContext();
        }


        public GenericRepository<T> DefaultRepository
        {
            get
            {
                if (this.defaultRepository == null)
                {
                    this.defaultRepository = new GenericRepository<T>(this.myContext);
                }
                return defaultRepository;
            }
        }


        public void Save()
        {
            try
            {
                this.myContext.SaveChanges();
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    this.myContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
