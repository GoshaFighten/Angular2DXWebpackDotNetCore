import { Injectable } from "@angular/core";
import { Http } from '@angular/http';

import { Order } from "../../models/order";

import { Observable } from 'rxjs/Observable';

@Injectable()
export class OrderService {
    constructor(private http: Http) { }
    getOrders(): Observable<Order[]> {
        return this.http.get('/api/SampleData/Orders')
            .map(res => {
                return res.json();
            });
    }
}