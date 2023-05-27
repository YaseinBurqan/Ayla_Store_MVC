using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.ReviewRow>;
using MyRow = AdminPanal.AylaStoreModule.ReviewRow;

namespace AdminPanal.AylaStoreModule;

public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ReviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewRetrieveHandler
{
    public ReviewRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}