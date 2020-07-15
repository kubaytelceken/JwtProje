using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.Concrete
{
    public class ProductManager : GenericManager<Product>,IProductService
    {
        public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
        {

        }

    }
}
