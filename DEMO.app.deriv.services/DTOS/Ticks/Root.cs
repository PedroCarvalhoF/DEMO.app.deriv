namespace DEMO.app.deriv.services.DTOS.Ticks
{
    public class Root
    {
        public EchoReq EchoReq { get; set; }
        public string MsgType { get; set; }
        public int ReqId { get; set; }
        public Subscription Subscription { get; set; }
        public Tick Tick { get; set; }
    }
}
