using Serenity.Services;
using MyRequest = AdminPanal.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanal.Administration.UserRow>;
using MyRow = AdminPanal.Administration.UserRow;

namespace AdminPanal.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}