using System.ComponentModel;

namespace Vavatech.PSI.WPF.Models
{
    public enum ActivityType
    {
        [Description("Pracuje")]
        Working,

        [Description("Odpoczywa")]
        Rest,

        [Description("Delegowany")]
        Delegated
    }
    
}
