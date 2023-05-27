import { StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ReviewForm {
    Name: StringEditor;
    Email: StringEditor;
    Description: StringEditor;
    EntryDate: DateEditor;
}

export class ReviewForm extends PrefixedContext {
    static formKey = 'AylaStoreModule.Review';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ReviewForm.init)  {
            ReviewForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;

            initFormType(ReviewForm, [
                'Name', w0,
                'Email', w0,
                'Description', w0,
                'EntryDate', w1
            ]);
        }
    }
}