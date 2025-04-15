namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public partial class SaleItem
    {
        public SaleItem(Guid productId, string productName, int quantity, decimal unitPrice, decimal discount, Guid saleId)
        {
            if (quantity < 1 || quantity > 20)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be between 1 and 20.");

            if (discount < 0 || discount > 1)
                throw new ArgumentOutOfRangeException(nameof(discount), "Discount must be between 0 and 1 (as percentage).");

            if (unitPrice < 0)
                throw new ArgumentOutOfRangeException(nameof(unitPrice), "UnitPrice must be greater than 0");

            if (productName.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(productName), "ProductName must have at least 3 characters");

            Id = Guid.NewGuid();
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Discount = discount;
            SaleId = saleId;
            IsCancelled = false;
        }

        /// <summary>
        /// Cancels this item.
        /// </summary>
        public void Cancel()
        {
            IsCancelled = true;
        }
    }
}
