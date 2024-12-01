namespace DEMO.app.deriv.services.DTOS.Ticks
{
    public class Tick
    {
        public double Ask { get; set; }
        public double Bid { get; set; }
        public long Epoch { get; set; }
        public string Id { get; set; }
        public int PipSize { get; set; }
        public double Quote { get; set; }
        public string Symbol { get; set; }
    }
}
