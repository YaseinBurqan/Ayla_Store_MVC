import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ShopingCartForm {
    UserId: StringEditor;
    ProductId: IntegerEditor;
    Quantity: IntegerEditor;
}

export class ShopingCartForm extends PrefixedContext {
    static formKey = 'AylaStoreModule.ShopingCart';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ShopingCartForm.init)  {
            ShopingCartForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ShopingCartForm, [
                'UserId', w0,
                'ProductId', w1,
                'Quantity', w1
            ]);
        }
    }
}