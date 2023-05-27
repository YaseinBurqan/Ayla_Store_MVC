import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ContactUsRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Subject?: string;
    Description?: string;
}

export abstract class ContactUsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AylaStoreModule.ContactUs';
    static readonly deletePermission = 'ContactUs';
    static readonly insertPermission = 'ContactUs';
    static readonly readPermission = 'ContactUs';
    static readonly updatePermission = 'ContactUs';

    static readonly Fields = fieldsProxy<ContactUsRow>();
}