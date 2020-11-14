using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Entities;
namespace ServicesApp.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
    }
}
