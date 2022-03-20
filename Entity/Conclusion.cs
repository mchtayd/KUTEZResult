using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Conclusion
    {
        string status; int smallDiameter, bigDiameter;

        public string Status { get => status; set => status = value; }
        public int SmallDiameter { get => smallDiameter; set => smallDiameter = value; }
        public int BigDiameter { get => bigDiameter; set => bigDiameter = value; }

        public Conclusion(string status, int smallDiameter, int bigDiameter)
        {
            this.status = status;
            this.smallDiameter = smallDiameter;
            this.bigDiameter = bigDiameter;
        }
    }

}
