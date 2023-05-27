import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ContactUsGrid } from './ContactUsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContactUsGrid($('#GridDiv')).element);
}