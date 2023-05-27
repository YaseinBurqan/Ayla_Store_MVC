using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.ShopingCartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.ShopingCartRow;

namespace AdminPanal.AylaStoreModule;

public interface IShopingCartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ShopingCartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IShopingCartSaveHandler
{
    public ShopingCartSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}