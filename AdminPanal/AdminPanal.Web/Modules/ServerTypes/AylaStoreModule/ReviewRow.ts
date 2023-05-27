import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ReviewRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Description?: string;
    EntryDate?: string;
}

export abstract class ReviewRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AylaStoreModule.Review';
    static readonly deletePermission = 'Review';
    static readonly insertPermission = 'Review';
    static readonly readPermission = 'Review';
    static readonly updatePermission = 'Review';

    static readonly Fields = fieldsProxy<ReviewRow>();
}