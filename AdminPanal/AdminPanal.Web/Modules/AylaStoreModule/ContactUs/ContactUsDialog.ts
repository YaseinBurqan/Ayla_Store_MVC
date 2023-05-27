import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ContactUsForm, ContactUsRow, ContactUsService } from '../../ServerTypes/AylaStoreModule';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ContactUsDialog')
export class ContactUsDialog extends EntityDialog<ContactUsRow, any> {
    protected getFormKey() { return ContactUsForm.formKey; }
    protected getRowDefinition() { return ContactUsRow; }
    protected getService() { return ContactUsService.baseUrl; }

    protected form = new ContactUsForm(this.idPrefix);
}