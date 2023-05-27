import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ShopingCartGrid } from './ShopingCartGrid';

export default function pageInit() {
    initFullHeightGridPage(new ShopingCartGrid($('#GridDiv')).element);
}