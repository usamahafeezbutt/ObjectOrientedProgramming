
namespace ObjectOrientedProgramming.Abstraction
{
    class Member : ApplicationUser, IApplicationUser
    {
        public override string LoginUser(string username, string password)
            // generate token
            => ValidateCredentials() ? "token" : "Login Failed";

        public override bool RegisterUser(object userDetails)
            //Validate user details
            //Store user details to database
            => true;

        private bool ValidateCredentials()
            // validate username and password
            => true;
    }
}
