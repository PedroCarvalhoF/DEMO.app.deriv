using System.Collections.Generic;

namespace DEMO.app.deriv.services.DTOS.Authorize
{
    public class AuthorizeDtoResponse
    { }
    public class AccountList
    {
        public string account_category { get; set; }
        public string account_type { get; set; }
        public string broker { get; set; }
        public int created_at { get; set; }
        public string currency { get; set; }
        public string currency_type { get; set; }
        public int is_disabled { get; set; }
        public int is_virtual { get; set; }
        public string landing_company_name { get; set; }
        public List<object> linked_to { get; set; }
        public string loginid { get; set; }
    }

    public class BRL
    {
        public int fractional_digits { get; set; }
    }

    public class LocalCurrencies
    {
        public BRL BRL { get; set; }
    }

    public class Root
    {
        public List<AccountList> account_list { get; set; }
        public int balance { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public int is_virtual { get; set; }
        public string landing_company_fullname { get; set; }
        public string landing_company_name { get; set; }
        public List<object> linked_to { get; set; }
        public LocalCurrencies local_currencies { get; set; }
        public string loginid { get; set; }
        public string preferred_language { get; set; }
        public List<string> scopes { get; set; }
        public List<string> upgradeable_landing_companies { get; set; }
        public int user_id { get; set; }
    }
}
