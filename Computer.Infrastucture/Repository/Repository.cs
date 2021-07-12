using Computer.Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Infrastucture.Repository
{
    public class Repository : IRepository
    {

        private readonly ComputerContext _ctx;
        public Repository(ComputerContext ctx)
        {
            this._ctx = ctx;
        }
        public bool SaveChange()
        {
            var count = _ctx.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }
    }
}
