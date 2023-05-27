import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductColumns, ProductRow, ProductService } from '../../ServerTypes/AylaStoreModule';
import { ProductDialog } from './ProductDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ProductGrid')
export class ProductGrid extends EntityGrid<ProductRow, any> {
    protected getColumnsKey() { return ProductColumns.columnsKey; }
    protected getDialogType() { return ProductDialog; }
    protected getRowDefinition() { return ProductRow; }
    protected getService() { return ProductService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}