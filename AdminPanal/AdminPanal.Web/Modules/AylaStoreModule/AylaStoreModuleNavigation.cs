using Serenity.Navigation;
using MyPages = AdminPanal.AylaStoreModule.Pages;

[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Category", typeof(MyPages.CategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Contact Us", typeof(MyPages.ContactUsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Product", typeof(MyPages.ProductPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Product Image", typeof(MyPages.ProductImagePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Review", typeof(MyPages.ReviewPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "AylaStoreModule/Shoping Cart", typeof(MyPages.ShopingCartPage), icon: null)]