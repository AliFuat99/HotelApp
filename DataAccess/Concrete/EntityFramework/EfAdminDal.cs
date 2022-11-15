using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin,Context>, IAdminDal 
    {
    }
}
