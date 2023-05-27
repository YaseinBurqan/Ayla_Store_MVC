using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanal.Administration.RoleRow>;
using MyRow = AdminPanal.Administration.RoleRow;


namespace AdminPanal.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}