﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntiityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,NorthwindContext>,ICustomerDal
    {
        
    }
}
