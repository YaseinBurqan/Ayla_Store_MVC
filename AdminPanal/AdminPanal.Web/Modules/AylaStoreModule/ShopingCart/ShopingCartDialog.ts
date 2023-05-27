import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ShopingCartForm, ShopingCartRow, ShopingCartService } from '../../ServerTypes/AylaStoreModule';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ShopingCartDialog')
export class ShopingCartDialog extends EntityDialog<ShopingCartRow, any> {
    protected getFormKey() { return ShopingCartForm.formKey; }
    protected getRowDefinition() { return ShopingCartRow; }
    protected getService() { return ShopingCartService.baseUrl; }

    protected form = new ShopingCartForm(this.idPrefix);
}