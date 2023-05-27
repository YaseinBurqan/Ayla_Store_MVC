using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.ProductImageRow>;
using MyRow = AdminPanal.AylaStoreModule.ProductImageRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductImageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProductImageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageRetrieveHandler
{
    public ProductImageRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}