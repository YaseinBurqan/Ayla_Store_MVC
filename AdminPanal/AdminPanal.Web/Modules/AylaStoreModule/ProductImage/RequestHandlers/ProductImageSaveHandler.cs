using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.ProductImageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.ProductImageRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductImageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProductImageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImageSaveHandler
{
    public ProductImageSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}