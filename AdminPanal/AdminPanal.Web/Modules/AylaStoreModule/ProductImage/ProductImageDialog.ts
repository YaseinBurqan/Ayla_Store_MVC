import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProductImageForm, ProductImageRow, ProductImageService } from '../../ServerTypes/AylaStoreModule';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ProductImageDialog')
export class ProductImageDialog extends EntityDialog<ProductImageRow, any> {
    protected getFormKey() { return ProductImageForm.formKey; }
    protected getRowDefinition() { return ProductImageRow; }
    protected getService() { return ProductImageService.baseUrl; }

    protected form = new ProductImageForm(this.idPrefix);
}