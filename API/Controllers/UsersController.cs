using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   
    public class UsersController : BaseApiController
    {
        //private readonly DataContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)

        {
            _mapper = mapper;
            _userRepository = userRepository;
            // _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            //return await _context.Users.ToListAsync();
            //var user = await _userRepository.GetUserAsync():

            // return Ok(await _userRepository.GetUserAsync());

/*             var users = await _userRepository.GetUserAsync();

            var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users); */

            var users = await _userRepository.GetMembersAsync();

            return Ok(users);
        }


        //api/users/3 <= 
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {

            //var user = await _userRepository.GetUserByUsernameAsync(username);

            // return _mapper.Map<MemberDto>(user);

             return await _userRepository.GetMemberAsync(username);

        }
    }
}