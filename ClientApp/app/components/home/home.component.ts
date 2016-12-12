import { Component, OnInit } from '@angular/core';

import { Order } from "../../models/order";
import { OrderService } from "../../services/order-service/order.service";

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    providers: [OrderService]
})
export class HomeComponent implements OnInit {
    constructor(private orderService: OrderService) { }
    ngOnInit(): void {
        this.getOrders();
    }
    orders: Order[];
    getOrders(): void {
        this.orderService.getOrders().subscribe(orders => this.orders = orders);
    }
}
