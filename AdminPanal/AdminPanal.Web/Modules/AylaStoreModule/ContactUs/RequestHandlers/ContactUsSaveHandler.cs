using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.AylaStoreModule.ContactUsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.AylaStoreModule.ContactUsRow;

namespace AdminPanal.AylaStoreModule;

public interface IContactUsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactUsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContactUsSaveHandler
{
    public ContactUsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}