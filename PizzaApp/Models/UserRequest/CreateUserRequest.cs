using Application.User.Commands;
using Domain.Model;

namespace ShopAPI.Models.UserRequest
{
    public class CreateUserRequest
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Gender { get; set; }

        public AddUserCommand ToCommand()
        {
            return new AddUserCommand(Name, Surname, Email, Password, Gender);
        }
    }
}
