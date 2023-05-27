using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.CategoryRow;

namespace AdminPanal.AylaStoreModule;

public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
{
    public CategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}