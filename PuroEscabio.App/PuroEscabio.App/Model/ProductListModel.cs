using FoundationStandard.ObjectHydrator;
using System.Collections.Generic;

namespace PuroEscabio.App.Model
{
    public class ProductListModel
    {

        public ProductListModel()
        {
            Hydrator<ProductModel> prodHydrator = new Hydrator<ProductModel>();
            Products = prodHydrator.GetList(15);
        }

        public IList<ProductModel> Products { get; set; }

    }
}
