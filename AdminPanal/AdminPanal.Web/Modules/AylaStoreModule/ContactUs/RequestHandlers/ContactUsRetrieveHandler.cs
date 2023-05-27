using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.AylaStoreModule.ContactUsRow>;
using MyRow = AdminPanal.AylaStoreModule.ContactUsRow;

namespace AdminPanal.AylaStoreModule;

public interface IContactUsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactUsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContactUsRetrieveHandler
{
    public ContactUsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}