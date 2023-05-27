using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.ProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.ProductRow;

namespace AdminPanal.AylaStoreModule;

public interface IProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductSaveHandler
{
    public ProductSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}