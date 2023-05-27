using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.AylaStoreModule.ContactUsRow>;
using MyRow = AdminPanal.AylaStoreModule.ContactUsRow;

namespace AdminPanal.AylaStoreModule;

public interface IContactUsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ContactUsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContactUsListHandler
{
    public ContactUsListHandler(IRequestContext context)
            : base(context)
    {
    }
}