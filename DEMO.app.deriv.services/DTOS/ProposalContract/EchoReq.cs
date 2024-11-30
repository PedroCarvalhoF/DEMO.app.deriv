namespace DEMO.app.deriv.services.DTOS.ProposalContract
{
    public class EchoReq
    {
        public decimal amount { get; set; }
        public string basis { get; set; }
        public string contract_type { get; set; }
        public string currency { get; set; }
        public int duration { get; set; }
        public string duration_unit { get; set; }
        public string product_type { get; set; }
        public int proposal { get; set; }
        public string symbol { get; set; }
    }
}
