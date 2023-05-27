using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanal.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanal.Administration.LanguageRow;


namespace AdminPanal.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}