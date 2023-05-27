using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.Administration.LanguageRow>;
using MyRow = AdminPanal.Administration.LanguageRow;


namespace AdminPanal.Administration
{
    public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
    {
        public LanguageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}