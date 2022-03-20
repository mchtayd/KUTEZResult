using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bracelet
    {
        int id, braceletNo, bigDiameter, smallDiameter;

        public int Id { get => id; set => id = value; }
        public int BraceletNo { get => braceletNo; set => braceletNo = value; }
        public int BigDiameter { get => bigDiameter; set => bigDiameter = value; }
        public int SmallDiameter { get => smallDiameter; set => smallDiameter = value; }

        public Bracelet(int id, int braceletNo, int bigDiameter, int smallDiameter)
        {
            this.id = id;
            this.braceletNo = braceletNo;
            this.bigDiameter = bigDiameter;
            this.smallDiameter = smallDiameter;
        }

        public Bracelet(int braceletNo, int bigDiameter, int smallDiameter)
        {
            this.braceletNo = braceletNo;
            this.bigDiameter = bigDiameter;
            this.smallDiameter = smallDiameter;
        }
    }
}
