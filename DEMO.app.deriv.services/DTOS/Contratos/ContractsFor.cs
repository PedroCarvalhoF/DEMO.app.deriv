using System.Collections.Generic;

namespace DEMO.app.deriv.services.DTOS.Contratos
{
    public class ContractsFor
    {
        public List<Available> available { get; set; }
        public int close { get; set; }
        public string feed_license { get; set; }
        public int hit_count { get; set; }
        public List<object> non_available { get; set; }
        public int open { get; set; }
        public double spot { get; set; }
    }
}
