﻿using System.Diagnostics.CodeAnalysis;

namespace Core.Entities.OrderAggregate;

public class Order : BaseEntity
{
    public Order(string buyerEmail, Address shipToAddress, DeliveryMethod deliveryMethod,
        IReadOnlyList<OrderItem> orderItems, decimal subtotal)
    {
        BuyerEmail = buyerEmail;
        ShipToAddress = shipToAddress;
        DeliveryMethod = deliveryMethod;
        OrderItems = orderItems;
        Subtotal = subtotal;
    }

    public Order()
    {
    }
    
    public string BuyerEmail { get; set; }
    public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
    public Address ShipToAddress { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }
    public IReadOnlyList<OrderItem> OrderItems { get; set; }
    public decimal Subtotal { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    public string PaymentItemId { get; set; }

    public decimal GetTotal()
    {
        return Subtotal + DeliveryMethod.Price;
    }
}