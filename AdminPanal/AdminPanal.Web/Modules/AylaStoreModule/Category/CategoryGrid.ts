import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '../../ServerTypes/AylaStoreModule';
import { CategoryDialog } from './CategoryDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.CategoryGrid')
export class CategoryGrid extends EntityGrid<CategoryRow, any> {
    protected getColumnsKey() { return CategoryColumns.columnsKey; }
    protected getDialogType() { return CategoryDialog; }
    protected getRowDefinition() { return CategoryRow; }
    protected getService() { return CategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}