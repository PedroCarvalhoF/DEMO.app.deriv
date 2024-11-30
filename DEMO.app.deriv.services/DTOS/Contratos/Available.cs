using System.Collections.Generic;

namespace DEMO.app.deriv.services.DTOS.Contratos
{
    public class Available
    {
        public string barrier_category { get; set; }
        public int barriers { get; set; }
        public string contract_category { get; set; }
        public string contract_category_display { get; set; }
        public string contract_display { get; set; }
        public string contract_type { get; set; }
        public int default_stake { get; set; }
        public string exchange_name { get; set; }
        public string expiry_type { get; set; }
        public List<double> growth_rate_range { get; set; }
        public string high_barrier { get; set; }
        public string low_barrier { get; set; }
        public string market { get; set; }
        public string max_contract_duration { get; set; }
        public string min_contract_duration { get; set; }
        public string sentiment { get; set; }
        public string start_type { get; set; }
        public string submarket { get; set; }
        public string underlying_symbol { get; set; }
        public string barrier { get; set; }
        public List<ForwardStartingOption> forward_starting_options { get; set; }
        public List<int> last_digit_range { get; set; }
        public List<string> cancellation_range { get; set; }
        public List<int> multiplier_range { get; set; }
    }
}
