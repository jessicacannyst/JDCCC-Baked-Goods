namespace JDCCC_Baked_Goods.Models
{
    public class OrderItemDTO
    {
        public int orderId { get; set; }
        public int cookieId { get; set; }
        public int orderQty { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime shipDate { get; set; }
        public string custName { get; set; }
        //WHERE CREDIT CARD WOULD GO NOT DTO
        public double totalPrice { get; set; }
    }
}
