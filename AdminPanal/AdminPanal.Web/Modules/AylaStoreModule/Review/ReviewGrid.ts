import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewColumns, ReviewRow, ReviewService } from '../../ServerTypes/AylaStoreModule';
import { ReviewDialog } from './ReviewDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ReviewGrid')
export class ReviewGrid extends EntityGrid<ReviewRow, any> {
    protected getColumnsKey() { return ReviewColumns.columnsKey; }
    protected getDialogType() { return ReviewDialog; }
    protected getRowDefinition() { return ReviewRow; }
    protected getService() { return ReviewService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}