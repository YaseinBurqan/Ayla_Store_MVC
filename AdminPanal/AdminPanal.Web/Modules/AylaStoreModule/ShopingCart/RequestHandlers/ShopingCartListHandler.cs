using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.ShopingCartRow>;
using MyRow = AdminPanal.AylaStoreModule.ShopingCartRow;

namespace AdminPanal.AylaStoreModule;

public interface IShopingCartListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ShopingCartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IShopingCartListHandler
{
    public ShopingCartListHandler(IRequestContext context)
            : base(context)
    {
    }
}