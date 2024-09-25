using E_Learning.Dtos.Category;
using E_Learning.Dtos.User;
using E_Learning.Dtos.ViewResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Application.IService
{
    public interface IUserService
    {
        Task<ResultView<UserDTO>> LoginAsync(UserLoginDTO userDto);
        Task<ResultView<RegisterDTO>> Registration(RegisterDTO account, string? RoleName);
        Task<bool> LogoutUser();
        Task<ResultView<List<UserDTO>>> GetAllUsers();
        Task<ResultView<List<UserDTO>>> GetAllUsersPages(int items, int pagenumber);
        Task<ResultView<UserDTO>> SoftDeleteUser(string email);

        //Task<ResultDataList<GetAllUserDTO>> GetAllInstructors();

        //Task<ResultView<BlockUserDTO>> BlockOrNotUser(BlockUserDTO blockUserDTO);

    }
}
