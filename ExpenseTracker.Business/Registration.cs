using AutoMapper;
using ExpenseTrackerWeb.Business.ExpenseTrackerRegistrationService;
using ExpenseTrackerWeb.BusinessObjects;
using System;
using System.ServiceModel.Web;

namespace ExpenseTrackerWeb.Business
{
    public class Registration
    {
        public UserValidation ValidateUser(User user)
        {
            UserDTO dto = new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName
            };
            RegistrationServiceClient registration = new RegistrationServiceClient();
            return Mapper.Map<UserValidation>(registration.ValidateUser(dto));  
        }

        public void CreateUser(User user)
        {
            UserDTO dto = new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password
            };
            RegistrationServiceClient registration = new RegistrationServiceClient();
            registration.Register(dto);
        }
    }
}
