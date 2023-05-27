import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ReviewGrid } from './ReviewGrid';

export default function pageInit() {
    initFullHeightGridPage(new ReviewGrid($('#GridDiv')).element);
}