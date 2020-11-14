using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    interface IUnitOfWork
    {


        void SaveChanges();

        Task SaveChangesAsync()
    }
}
