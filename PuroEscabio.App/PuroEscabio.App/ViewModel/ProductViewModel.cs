namespace PuroEscabio.App.ViewModel
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public string ProductAndCost => $"{ProductName} - ${Cost}";
        public string SKU { get; set; }
        public string PicName { get; set; }
        public bool Selected { get; set; }
    }
}
