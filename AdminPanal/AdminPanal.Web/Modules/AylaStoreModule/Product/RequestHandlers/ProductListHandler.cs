using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.ProductRow>;
using MyRow = AdminPanal.AylaStoreModule.ProductRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
{
    public ProductListHandler(IRequestContext context)
            : base(context)
    {
    }
}