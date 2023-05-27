using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.ReviewRow>;
using MyRow = AdminPanal.AylaStoreModule.ReviewRow;

namespace AdminPanal.AylaStoreModule;

public interface IReviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ReviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewListHandler
{
    public ReviewListHandler(IRequestContext context)
            : base(context)
    {
    }
}