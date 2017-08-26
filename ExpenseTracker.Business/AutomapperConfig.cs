using AutoMapper;
using ExpenseTrackerWeb.Business.ExpenseTrackerAuthenticationService;
using ExpenseTrackerWeb.Business.ExpenseTrackerRegistrationService;
using ExpenseTrackerWeb.Business.ExpenseTrackerService;
using ExpenseTrackerWeb.BusinessObjects;

namespace ExpenseTrackerWeb.Business
{
    public static class AutomapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<UserValidationDTO, UserValidation>();
                cfg.CreateMap<AuthenticateResultDTO, AuthenticateResult>();
                cfg.CreateMap<TransactionReceiptDTO, TransactionReceipt>();
                cfg.CreateMap<TransactionDTO, Transaction>();
                cfg.CreateMap<TransactionCategoryDTO, TransactionCategory>();
                cfg.CreateMap<BusinessObjects.SearchPeriod, ExpenseTrackerService.SearchPeriod>();
                cfg.CreateMap<TransactionSearchCriteria, TransactionSearchCriteriaDTO>();
            });
        }
    }
}
