
namespace ObjectOrientedProgramming.Abstraction
{
    class Admin : ApplicationUser, IApplicationUser
    {

        public override string LoginUser(string username, string password)
            // validate username and password
            // generate token
            => "token";

        public override bool RegisterUser(object userDetails)
            //Validate user details
            //Store user details to database
            => ValidateUserDetails() ? true: false;
        private bool ValidateUserDetails()
            // validate username and password
            => true;
        public bool DeleteUserAccount(string username)
            // Delete user account from database
            => true;
    }
}
