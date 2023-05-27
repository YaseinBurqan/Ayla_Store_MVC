using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.CategoryRow>;
using MyRow = AdminPanal.AylaStoreModule.CategoryRow;

namespace AdminPanal.AylaStoreModule;

public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryRetrieveHandler
{
    public CategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}