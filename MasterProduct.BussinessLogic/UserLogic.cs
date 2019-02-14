using MasterProduct.BussinessEntities;
using MasterProduct.DataAccess.SQL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MasterProduct.BussinessLogic
{
    public class UserLogic
    {
        #region Get all User
        public List<UserBE> GetUserAll()
        {
            List<UserBE> ltsuser = new List<UserBE>();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                ltsuser = (from User in BDMP.User
                           select new UserBE
                           {
                               IdUser = User.IdUser,
                               NameUser = User.NameUser,
                               Photo=User.Photo
                           }).OrderBy(x => x.NameUser).ToList();
            }
            catch (Exception EX)
            {

            }
            finally
            {
                BDMP.Dispose();
            }

            return ltsuser;
        }

        #endregion


        #region Insert User
        public AnswerResponseBE InsertUser(UserBE IUS)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                int CountUser = 0;
                CountUser = BDMP.User.Where(x => x.IdUser == IUS.IdUser).ToList().Count();
                if (CountUser == 0)
                {
                    User USER = new User();
                    USER.IdUser = IUS.IdUser;
                    USER.NameUser = IUS.NameUser;
                    USER.Photo = IUS.Photo;

                    BDMP.User.Add(USER);
                    BDMP.SaveChanges();

                    AR.CodeError = 0;
                    AR.DescriptionError = "Se ha insertado el usuario correctamente";
                }
                else
                {
                    AR.CodeError = 2;
                    AR.DescriptionError = "El usuario ya existe, por favor verifique la información";
                }
            }
            catch (Exception EX)
            {
                AR.CodeError = 1;
                AR.DescriptionError = "Hubo un error";
            }
            finally
            {
                BDMP.Dispose();
            }

            return AR;
        }
        #endregion


        #region Update User
        public AnswerResponseBE UpdateUser(UserBE UPUS)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                User user = new User();
                user = BDMP.User.Where(x => x.IdUser == UPUS.IdUser).FirstOrDefault();
                if (user != null)
                {
                    user.IdUser = UPUS.IdUser;
                    user.NameUser = UPUS.NameUser;
                    user.Photo = UPUS.Photo;
                   

                    BDMP.SaveChanges();

                    AR.CodeError = 0;
                    AR.DescriptionError = "Se ha actualizado el usuario correctamente";
                }
                else
                {
                    AR.CodeError = 2;
                    AR.DescriptionError = "El registro no existe, por favor verifique la información";
                }
            }
            catch (Exception EX)
            {
                AR.CodeError = 1;
                AR.DescriptionError = "Hubo un error";
            }
            finally
            {
                BDMP.Dispose();
            }


            return AR;
        }
        #endregion
    }
}
