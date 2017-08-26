using System.ServiceModel.Web;

namespace ExpenseTrackerWeb.Business
{
    public class BaseBuilder
    {
        public BaseBuilder(string authToken)
        {
            this.AuthToken = authToken;
        }
        public string AuthToken { get; set; }

        protected void AddAuthTokenHeader()
        {
            WebOperationContext.Current.OutgoingRequest.Headers.Add("AUTH_TOKEN", AuthToken);
        }
    }
}
