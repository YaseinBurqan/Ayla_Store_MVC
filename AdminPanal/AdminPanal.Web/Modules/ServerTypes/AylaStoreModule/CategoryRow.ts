import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Photo?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AylaStoreModule.Category';
    static readonly lookupKey = 'AylaStoreModule.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('AylaStoreModule.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('AylaStoreModule.Category') }

    static readonly deletePermission = 'Category';
    static readonly insertPermission = 'Category';
    static readonly readPermission = 'Category';
    static readonly updatePermission = 'Category';

    static readonly Fields = fieldsProxy<CategoryRow>();
}