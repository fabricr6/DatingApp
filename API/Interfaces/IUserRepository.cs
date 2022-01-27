using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void update(AppUser user);
        
        Task<bool> SaveAllSync();

        Task<IEnumerable<AppUser>> GetUserAsync();

        Task <AppUser> GetUserByIdAsync(int Id);

        Task<AppUser> GetUserByUsernameAsync(string username);

        Task <IEnumerable<MemberDto>> GetMembersAsync();

        Task<MemberDto> GetMemberAsync();

        

    }
}