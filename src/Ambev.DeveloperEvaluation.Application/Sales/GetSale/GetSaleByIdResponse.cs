﻿namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleByIdResponse
    {
        public Guid Id { get; set; }
        public string SaleNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public bool IsCancelled { get; set; }
        public List<GetSaleItemResponse> Items { get; set; } = new();
    }
}
