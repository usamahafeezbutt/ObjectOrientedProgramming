

namespace ObjectOrientedProgramming.Abstraction
{
    abstract class ApplicationUser
    {
        public abstract bool RegisterUser(object userDetails);
        public abstract string LoginUser(string username, string password);
    }
}
