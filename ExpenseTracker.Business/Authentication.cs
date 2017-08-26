using AutoMapper;
using ExpenseTrackerWeb.Business.ExpenseTrackerAuthenticationService;
using ExpenseTrackerWeb.BusinessObjects;

namespace ExpenseTrackerWeb.Business
{
    public class Authentication
    {
        public AuthenticateResult Authenticate(UserCredentials userCredential)
        {
            Credentials credentials = new Credentials
            {
                UserName = userCredential.UserName,
                Password = userCredential.Password
            };
            AuthenticationServiceClient authenticateService = new AuthenticationServiceClient();
            return Mapper.Map<AuthenticateResult>(authenticateService.Authenticate(credentials));
        }
    }
}
