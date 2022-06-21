
namespace ObjectOrientedProgramming.Abstraction
{
    interface IApplicationUser
    {
        bool RegisterUser(object userDetails);
        string LoginUser(string username, string password);
    }
}
