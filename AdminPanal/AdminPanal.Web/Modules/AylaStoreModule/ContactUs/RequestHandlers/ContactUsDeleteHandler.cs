using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanal.AylaStoreModule.ContactUsRow;

namespace AdminPanal.AylaStoreModule;

public interface IContactUsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ContactUsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContactUsDeleteHandler
{
    public ContactUsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}