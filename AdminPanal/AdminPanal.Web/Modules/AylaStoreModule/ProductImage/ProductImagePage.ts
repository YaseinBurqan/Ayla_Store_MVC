import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProductImageGrid } from './ProductImageGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProductImageGrid($('#GridDiv')).element);
}