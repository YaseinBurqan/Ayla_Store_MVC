using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.CategoryRow>;
using MyRow = AdminPanal.AylaStoreModule.CategoryRow;

namespace AdminPanal.AylaStoreModule;

public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
{
    public CategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}