using FoundationStandard.ObjectHydrator;
using PuroEscabio.App.ViewModel;
using System;
using System.Collections.Generic;


namespace PuroEscabio.App.Model
{
    public class ProductListModel
    {
        private string[] productsNameList = { "brahamaLata",
            "brahamaLitro",
            "campari",
           "champagneChandon",
           "champagneNavarrocorrea",
           "champagneVaronb",
           "coronaLata",
           "coronaPersonal",
           "fernet1982",
           "fernetBranca",
           "gancia",
           "patagoniaLitro",
           "patagoniaLata",
           "vinoCalia",
           "vinoDonvalentin",
           "vinoLopez",
           "vodkaSmirnoff",
           "wiskyJackdaniels",
           "wiskySingleton",
           "wiskySmuggler"
        };

        public ProductListModel()
        {
            Hydrator<ProductViewModel> prodHydrator = new Hydrator<ProductViewModel>();
            Products = GenerarLista();
        }

        private IList<ProductViewModel> GenerarLista()
        {
            var products = new List<ProductViewModel>();
            var random = new Random();

            for (int i = 0; i < productsNameList.Length; i++)
            {
                products.Add(new ProductViewModel
                {
                    Cost = random.Next(1, 1000),
                    PicName = $"{productsNameList[i]}.jfif",
                    ProductName = productsNameList[i],
                    SKU = $"{productsNameList[i]}{random.Next(1000, 3000)}",
                    Selected = false

                });
            }


            return products;
        }

        public IList<ProductViewModel> Products { get; set; }



    }
}
