namespace DEMO.app.deriv.services.DTOS.ProposalContract
{
    public class Proposal
    {
        public decimal ask_price { get; set; }
        public ContractDetails contract_details { get; set; }
        public long date_expiry { get; set; }
        public long date_start { get; set; }
        public string display_value { get; set; }
        public string id { get; set; }
        public string longcode { get; set; }
        public decimal payout { get; set; }
        public decimal spot { get; set; }
        public long spot_time { get; set; }
        public ValidationParams validation_params { get; set; }
    }
}
