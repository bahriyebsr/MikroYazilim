using MikroYazilim.Business.Dtos;
using MikroYazilim.Business.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikroYazilim.Business.Services
{
	public interface IUserService
	{
		ServiceMessage AddUser(AddUserDto addUserDto);
		UserInfoDto LoginUser(LoginDto loginDto);

	}
}
