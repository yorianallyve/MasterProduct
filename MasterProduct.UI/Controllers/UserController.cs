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
    [Route("api/User")]
    public class UserController : Controller
    {
        #region Insert User 
        [HttpPost("[action]")]
        public AnswerResponseBE InsertProduct([FromBody]UserBE IUS)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            UserLogic UL = new UserLogic();
            AR = UL.InsertUser(IUS);
            return AR;
        }
        #endregion


        #region Update User
        [HttpPut("[action]")]
        public AnswerResponseBE UpdateUser([FromBody]UserBE UPUS)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            UserLogic UL = new UserLogic();
            AR = UL.UpdateUser(UPUS);
            return AR;
        }
        #endregion


        #region Get User All
        [HttpGet("[action]")]
        public List<UserBE> GetUserAll()
        {
            List<UserBE> ltsuser = new List<UserBE>();
            UserLogic UL = new UserLogic();
            ltsuser = UL.GetUserAll();
            return ltsuser;
        }
        #endregion
    }
}