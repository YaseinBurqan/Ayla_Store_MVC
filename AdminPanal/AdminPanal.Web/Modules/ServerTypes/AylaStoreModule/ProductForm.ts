import { StringEditor, DecimalEditor, LookupEditor, ImageUploadEditor, IntegerEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProductForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    CategoryId: LookupEditor;
    Photo: ImageUploadEditor;
    Quantity: IntegerEditor;
    Type: StringEditor;
    SupplierName: StringEditor;
    EntryDate: DateEditor;
    ReviewUrl: StringEditor;
}

export class ProductForm extends PrefixedContext {
    static formKey = 'AylaStoreModule.Product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductForm.init)  {
            ProductForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = LookupEditor;
            var w3 = ImageUploadEditor;
            var w4 = IntegerEditor;
            var w5 = DateEditor;

            initFormType(ProductForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'CategoryId', w2,
                'Photo', w3,
                'Quantity', w4,
                'Type', w0,
                'SupplierName', w0,
                'EntryDate', w5,
                'ReviewUrl', w0
            ]);
        }
    }
}