using System;
using System.Globalization;
using System.Text;
using Pedidos.Entities.enuns;
namespace Pedidos.Entities{
    class Order{
        public DateTime Moment{get; set;}
        public OrderStatus Status{get; set;}
        public Cliente Client{get; set;}
        public List <OrderItem> Items{get; set;} = new List<OrderItem>();
        
        public Order(){

        }
        public Order(DateTime moment, OrderStatus status, Cliente cliente){
            Moment = moment;
            Status = Status;
            Client = cliente;

        }

        public void AddItem(OrderItem item){
            Items.Add(item);
        }


        public void Removeitem(OrderItem item){
            Items.Remove(item);
        }
        public double Total(){
            double sum = 0.0;
            foreach(OrderItem item in Items){
                sum+= item.Subtotal();
            }
            return sum;
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Order moment" + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
           sb.AppendLine("Order Status: " + Status);
           sb.AppendLine("Client: "+ Client);
           sb.AppendLine("Order items: ");
           foreach(OrderItem item in Items){
            sb.AppendLine(item.ToString());
           }
           sb.AppendLine("Total price: $"+ Total().ToString("F2", CultureInfo.InvariantCulture));
           return sb.ToString();

        }

    }
}