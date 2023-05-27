import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoryForm {
    Name: StringEditor;
    Description: StringEditor;
    Photo: StringEditor;
}

export class CategoryForm extends PrefixedContext {
    static formKey = 'AylaStoreModule.Category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoryForm.init)  {
            CategoryForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoryForm, [
                'Name', w0,
                'Description', w0,
                'Photo', w0
            ]);
        }
    }
}