using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanal.AylaStoreModule.ShopingCartRow;

namespace AdminPanal.AylaStoreModule;

public interface IShopingCartDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ShopingCartDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IShopingCartDeleteHandler
{
    public ShopingCartDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}