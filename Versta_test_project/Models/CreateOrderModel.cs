using System.ComponentModel.DataAnnotations;

namespace Versta_test_project.Models
{
    public class CreateOrderModel
    {

        [Display(Name = "Город отправителя:")]
        [Required(ErrorMessage = "Введите город отправителя:")]
        public string senderCity { get; set; }

        [Display(Name = "Адрес отправителя:")]
        [Required(ErrorMessage = "Введите адрес отправителя:")]
        public string senderAddress { get; set; }

        [Display(Name = "Город получателя:")]
        [Required(ErrorMessage = "Введите город получателя:")]
        public string recipientCity { get; set; }
        
        [Display(Name = "Адрес получателя:")]
        [Required(ErrorMessage = "Введите адрес получателя:")]
        public string recipientAddress { get; set; }
        
        [Display(Name = "Вес посылки, кг:")]
        [Required(ErrorMessage = "Введите вес посылки:")]
        public double? packageWeight { get; set; }

        [Display(Name = "Дата забора груза:")]
        [Required(ErrorMessage = "Введите дату забора груза:")]
        public DateTime? collectionDate { get; set; }

        public OrderModel SaveOrder()
        {
            OrderModel order = new OrderModel();
            order.senderCity = senderCity;
            order.senderAddress = senderAddress;
            order.recipientCity = recipientCity;
            order.recipientAddress = recipientAddress;
            order.packageWeight = packageWeight;
            order.collectionDate = collectionDate;
            return order;
        }

    }
}
