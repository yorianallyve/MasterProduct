using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterProduct.BussinessEntities;
using MasterProduct.BussinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterProduct.UI.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        #region Insert Product 
        [HttpPost("[action]")]
        public AnswerResponseBE InsertProduct([FromBody]ProductBE IPROD)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            ProductLogic PL = new ProductLogic();
            AR = PL.InsertProduct(IPROD);
            return AR;
        }
        #endregion


        #region Get Product All 
        [HttpGet("[action]")]
        public List<ProductBE> GetProductAll([FromQuery]bool STATPROD)
        {
            List<ProductBE> ltsprodtall = new List<ProductBE>();
            ProductLogic PL = new ProductLogic();
            ltsprodtall = PL.GetProductdTAll(STATPROD);
            return ltsprodtall;
        }
        #endregion 


        #region Update Product
        [HttpPut("[action]")]
        public AnswerResponseBE UpdateProduct([FromBody]ProductBE UPPROD)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            ProductLogic PL = new ProductLogic();
            AR = PL.UpdateProduct(UPPROD);
            return AR;
        }
        #endregion
        
        
        #region Search Product Id     
        [HttpGet("[action]")]
        public ProductBE SearchIdProduct([FromQuery]int SEARIDPRO)
        {
            ProductLogic PRODL = new ProductLogic();
            var ARS = PRODL.SearchIdProduct(SEARIDPRO);
            return ARS;
        }
        #endregion
    }
}