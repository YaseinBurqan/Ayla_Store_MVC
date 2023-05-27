import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ShopingCartRow {
    Id?: number;
    UserId?: string;
    ProductId?: number;
    Quantity?: number;
    ProductName?: string;
}

export abstract class ShopingCartRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'UserId';
    static readonly localTextPrefix = 'AylaStoreModule.ShopingCart';
    static readonly deletePermission = 'ShopingCart';
    static readonly insertPermission = 'ShopingCart';
    static readonly readPermission = 'ShopingCart';
    static readonly updatePermission = 'ShopingCart';

    static readonly Fields = fieldsProxy<ShopingCartRow>();
}