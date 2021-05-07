using System;

namespace TryRL
{
    public class SimulateButton: HubDesign
    {
        public int nextDay {get; set;}
        public void CheckDate()
        {
            this.nextDay++;
        }
    }
}
