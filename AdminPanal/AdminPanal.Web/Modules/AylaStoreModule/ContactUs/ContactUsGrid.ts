import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContactUsColumns, ContactUsRow, ContactUsService } from '../../ServerTypes/AylaStoreModule';
import { ContactUsDialog } from './ContactUsDialog';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ContactUsGrid')
export class ContactUsGrid extends EntityGrid<ContactUsRow, any> {
    protected getColumnsKey() { return ContactUsColumns.columnsKey; }
    protected getDialogType() { return ContactUsDialog; }
    protected getRowDefinition() { return ContactUsRow; }
    protected getService() { return ContactUsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}