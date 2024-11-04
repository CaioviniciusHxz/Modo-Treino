using System;

namespace Pedidos.Entities.enuns{
    enum OrderStatus : int{
        Pending_PaYMENT = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}