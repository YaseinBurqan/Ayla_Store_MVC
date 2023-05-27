import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    CategoryId?: number;
    Photo?: string;
    Quantity?: number;
    Type?: string;
    SupplierName?: string;
    EntryDate?: string;
    ReviewUrl?: string;
    CategoryName?: string;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AylaStoreModule.Product';
    static readonly deletePermission = 'Product';
    static readonly insertPermission = 'Product';
    static readonly readPermission = 'Product';
    static readonly updatePermission = 'Product';

    static readonly Fields = fieldsProxy<ProductRow>();
}