using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.Administration.RoleRow>;
using MyRow = AdminPanal.Administration.RoleRow;


namespace AdminPanal.Administration
{
    public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
    {
        public RoleListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}