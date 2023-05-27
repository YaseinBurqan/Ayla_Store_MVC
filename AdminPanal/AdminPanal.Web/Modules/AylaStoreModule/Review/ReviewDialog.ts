import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ReviewForm, ReviewRow, ReviewService } from '../../ServerTypes/AylaStoreModule';

@Decorators.registerClass('AdminPanal.AylaStoreModule.ReviewDialog')
export class ReviewDialog extends EntityDialog<ReviewRow, any> {
    protected getFormKey() { return ReviewForm.formKey; }
    protected getRowDefinition() { return ReviewRow; }
    protected getService() { return ReviewService.baseUrl; }

    protected form = new ReviewForm(this.idPrefix);
}