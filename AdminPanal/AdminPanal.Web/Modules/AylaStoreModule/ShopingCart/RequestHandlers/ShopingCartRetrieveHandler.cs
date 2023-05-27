using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.ShopingCartRow>;
using MyRow = AdminPanal.AylaStoreModule.ShopingCartRow;

namespace AdminPanal.AylaStoreModule;

public interface IShopingCartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ShopingCartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IShopingCartRetrieveHandler
{
    public ShopingCartRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}