import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ContactUsForm {
    Name: StringEditor;
    Email: StringEditor;
    Subject: StringEditor;
    Description: StringEditor;
}

export class ContactUsForm extends PrefixedContext {
    static formKey = 'AylaStoreModule.ContactUs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContactUsForm.init)  {
            ContactUsForm.init = true;

            var w0 = StringEditor;

            initFormType(ContactUsForm, [
                'Name', w0,
                'Email', w0,
                'Subject', w0,
                'Description', w0
            ]);
        }
    }
}