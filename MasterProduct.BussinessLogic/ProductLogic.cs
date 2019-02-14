using MasterProduct.BussinessEntities;
using MasterProduct.DataAccess.SQL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MasterProduct.BussinessLogic
{
    public class ProductLogic
    {
        #region Search Product for IdProduct
        public ProductBE SearchIdProduct(int SEARIDPROCUP)
        {
            MasterProductContext BDMP = new MasterProductContext();
            ProductBE idprocupbo = new ProductBE();
            try
            {
                idprocupbo = (from Product in BDMP.Product
                              where Product.IdProduct == SEARIDPROCUP
                              select new ProductBE
                              {
                                  IdProduct = Product.IdProduct,
                                  NameProduct = Product.NameProduct,
                                  Properties = Product.Properties,
                                  ReleaseDate = Product.ReleaseDate,
                                  ManufacturerEmail = Product.ManufacturerEmail,
                                  IdCountry = Product.IdCountry,
                                  Cost = Product.Cost,
                                  UnitsAvailable = Product.UnitsAvailable,
                                  SoldUnits = Product.SoldUnits,
                                  StateProduct = Product.StateProduct,
                                  ImageProduct = Product.ImageProduct
                              }).FirstOrDefault();
            }
            catch (Exception EX)
            {

            }
            finally
            {
                BDMP.Dispose();
            }

            return idprocupbo;
        }

        #endregion


        #region Insert Product
        public AnswerResponseBE InsertProduct(ProductBE IPROD)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                int CountProd = 0;
                CountProd = BDMP.Product.Where(x => x.IdProduct == IPROD.IdProduct).ToList().Count();
                if (CountProd == 0)
                {
                    Product PROD = new Product();
                    PROD.IdProduct = IPROD.IdProduct;
                    PROD.NameProduct = IPROD.NameProduct;
                    PROD.Properties = IPROD.Properties;
                    PROD.ReleaseDate = IPROD.ReleaseDate;
                    PROD.ManufacturerEmail = IPROD.ManufacturerEmail;
                    PROD.IdCountry = IPROD.IdCountry;
                    PROD.Cost = IPROD.Cost;
                    PROD.UnitsAvailable = IPROD.UnitsAvailable;
                    PROD.SoldUnits = IPROD.SoldUnits;
                    PROD.StateProduct = IPROD.StateProduct;
                    PROD.ImageProduct = IPROD.ImageProduct;

                    BDMP.Product.Add(PROD);
                    BDMP.SaveChanges();

                    AR.CodeError = 0;
                    AR.DescriptionError = "Se ha insertado el producto correctamente";
                }
                else
                {
                    AR.CodeError = 2;
                    AR.DescriptionError = "El producto ya existe, por favor verifique la información";
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


        #region Update Product
        public AnswerResponseBE UpdateProduct(ProductBE UPROD)
        {
            AnswerResponseBE AR = new AnswerResponseBE();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                Product product = new Product();
                product = BDMP.Product.Where(x => x.IdProduct == UPROD.IdProduct).FirstOrDefault();
                if (product != null)
                {
                    product.IdProduct = UPROD.IdProduct;
                    product.NameProduct = UPROD.NameProduct;
                    product.Properties = UPROD.Properties;
                    product.ReleaseDate = UPROD.ReleaseDate;
                    product.ManufacturerEmail = UPROD.ManufacturerEmail;
                    product.IdCountry = UPROD.IdCountry;
                    product.Cost = UPROD.Cost;
                    product.UnitsAvailable = UPROD.UnitsAvailable;
                    product.SoldUnits = UPROD.SoldUnits;
                    product.StateProduct = UPROD.StateProduct;
                    product.ImageProduct = UPROD.ImageProduct;

                    BDMP.SaveChanges();

                    AR.CodeError = 0;
                    AR.DescriptionError = "Se ha actualizado el producto correctamente";
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


        #region Get all Product
        public List<ProductBE> GetProductdTAll(bool STATPROD)
        {
            List<ProductBE> lstprod = new List<ProductBE>();
            MasterProductContext BDMP = new MasterProductContext();
            try
            {
                lstprod = (from Product in BDMP.Product
                           where Product.StateProduct == STATPROD

                           select new ProductBE
                           {
                               IdProduct = Product.IdProduct,
                               NameProduct = Product.NameProduct,
                               Properties = Product.Properties,
                               ReleaseDate = Product.ReleaseDate,
                               ManufacturerEmail = Product.ManufacturerEmail,
                               IdCountry = Product.IdCountry,
                               Cost = Product.Cost,
                               UnitsAvailable = Product.UnitsAvailable,
                               SoldUnits = Product.SoldUnits,
                               StateProduct = Product.StateProduct,
                               ImageProduct = Product.ImageProduct
                           }).OrderBy(x => x.ReleaseDate).ThenBy(x => x.StateProduct).ToList();
            }
            catch (Exception EX)
            {

            }
            finally
            {
                BDMP.Dispose();
            }

            return lstprod;
        }
        #endregion

    }
}
