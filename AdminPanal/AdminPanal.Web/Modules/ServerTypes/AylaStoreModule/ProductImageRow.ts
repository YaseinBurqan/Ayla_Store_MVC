import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProductImageRow {
    Id?: number;
    ProductId?: number;
    Image?: string;
    ProductName?: string;
}

export abstract class ProductImageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'AylaStoreModule.ProductImage';
    static readonly deletePermission = 'ProductImage';
    static readonly insertPermission = 'ProductImage';
    static readonly readPermission = 'ProductImage';
    static readonly updatePermission = 'ProductImage';

    static readonly Fields = fieldsProxy<ProductImageRow>();
}