using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using DI.Core;
using DI.Core.Data;
using DI.Data;

namespace Web_API_AD_T4.Controllers
{
 
    public class ValuesController<T> : ApiController where T : BaseEntity
    {
        UnitOfWork uow = new UnitOfWork();
        private static Respority<T> ApiRespority;

        public ValuesController()
        {
            ApiRespority = uow.Repository<T>();
        }


        [System.Web.Http.Route("getall")]
        public IEnumerable<T> Get()
        {
            return ApiRespority.GetAll();
        }

        [System.Web.Http.Route("getbyid/{id}")]
        public T Get(Guid id)
        {
            var item= uow.Repository<T>().GetById(id);
            return item;
        }

        [System.Web.Http.Route("Create")]
        [HttpPost]
        public void Post(T items)
        {
            ApiRespority.Insert(items);
        }

        [System.Web.Http.Route("Update")]
        [HttpPost]
        public void Put(T items)
        {
            ApiRespority.Update(items);
        }

        [System.Web.Http.Route("delete/{id}")]
        public void Delete(Guid id)
        {
            var delitem = ApiRespority.GetById(id);
            ApiRespority.Delete(delitem);
        }
    }

    [RoutePrefix("api/Stock")]
    public class StockController : ValuesController<Stock>
    {
    }
    [RoutePrefix("api/Category")]
    public class CategoryController : ValuesController<Category>
    {
    }

}
