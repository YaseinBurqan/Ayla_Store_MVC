import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ShopingCartColumns, ShopingCartRow, ShopingCartService } from '../../ServerTypes/AylaStoreModule';
import { ShopingCartDialog } from './ShopingCartDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ShopingCartGrid')
export class ShopingCartGrid extends EntityGrid<ShopingCartRow, any> {
    protected getColumnsKey() { return ShopingCartColumns.columnsKey; }
    protected getDialogType() { return ShopingCartDialog; }
    protected getRowDefinition() { return ShopingCartRow; }
    protected getService() { return ShopingCartService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}