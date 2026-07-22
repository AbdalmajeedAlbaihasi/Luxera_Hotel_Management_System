using HMSDataAccessLayer;
using HMSDesktop.Services;

namespace HMSDesktop.ApplicationServices
{
    public class UserService
    {
        private readonly UserApiService _api;

        public string LastError => _api.LastError;

        public UserService()
        {
            _api = new UserApiService();
        }


        public async Task<List<UserListDTO>> GetUsersAsync()
        {
            return await _api.GetAllUsersAsync();
        }


        public async Task<OneUserListDTO> GetByIdAsync(int id)
        {
            return await _api.GetByIdAsync(id);
        }


        public async Task<OneUserListDTO> GetByUsernameAsync(string username)
        {
            return await _api.GetByUserNameAsync(username);
        }


        public async Task<bool> AddUserAsync(AddNewUserDTO dto)
        {
            if (dto == null)
                return false;

            return await _api.AddUserAsync(dto);
        }


        public async Task<bool> UpdateUserAsync(int id, UpdateUserDTO dto)
        {
            if (id <= 0 || dto == null)
                return false;

            return await _api.UpdateUserAsync(id, dto);
        }


        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _api.DeleteUserAsync(id);
        }


        public async Task<UserLoginDTO> UserLoginAsync(LoginDTO dto)
        {
            return await _api.LoginAsync(dto);
        }

    }
}