using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.ReviewRow;

namespace AdminPanal.AylaStoreModule;

public interface IReviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ReviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewSaveHandler
{
    public ReviewSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}