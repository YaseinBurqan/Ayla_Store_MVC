using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.ProductImageRow>;
using MyRow = AdminPanal.AylaStoreModule.ProductImageRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductImageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProductImageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageListHandler
{
    public ProductImageListHandler(IRequestContext context)
            : base(context)
    {
    }
}