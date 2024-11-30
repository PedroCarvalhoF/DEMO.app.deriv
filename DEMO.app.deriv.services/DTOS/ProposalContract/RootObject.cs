using DEMO.app.deriv.services.DTOS.Contratos;

namespace DEMO.app.deriv.services.DTOS.ProposalContract
{
    public class RootObject
    {
        public EchoReq echo_req { get; set; }
        public string msg_type { get; set; }
        public Proposal proposal { get; set; }
    }
}
