using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.ProductRow>;
using MyRow = AdminPanal.AylaStoreModule.ProductRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductRetrieveHandler
{
    public ProductRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}