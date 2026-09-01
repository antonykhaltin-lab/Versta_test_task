using System.ComponentModel.DataAnnotations;

namespace Versta_test_project.Models
{
    public class OrderModel
    {
        public int ID { get; set; } = 0;
        public string senderCity { get; set; }
        public string senderAddress { get; set; }
        public string recipientCity { get; set; }
        public string recipientAddress { get; set; }
        public double? packageWeight { get; set; }
        public DateTime? collectionDate { get; set; }
    }
}
