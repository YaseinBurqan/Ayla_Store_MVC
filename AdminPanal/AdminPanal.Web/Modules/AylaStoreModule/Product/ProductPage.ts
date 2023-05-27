import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProductGrid } from './ProductGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProductGrid($('#GridDiv')).element);
}