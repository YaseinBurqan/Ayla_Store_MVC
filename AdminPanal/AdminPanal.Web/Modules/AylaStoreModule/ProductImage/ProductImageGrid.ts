import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductImageColumns, ProductImageRow, ProductImageService } from '../../ServerTypes/AylaStoreModule';
import { ProductImageDialog } from './ProductImageDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ProductImageGrid')
export class ProductImageGrid extends EntityGrid<ProductImageRow, any> {
    protected getColumnsKey() { return ProductImageColumns.columnsKey; }
    protected getDialogType() { return ProductImageDialog; }
    protected getRowDefinition() { return ProductImageRow; }
    protected getService() { return ProductImageService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}