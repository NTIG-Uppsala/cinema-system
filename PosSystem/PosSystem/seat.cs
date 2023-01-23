using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class seat
    {

        public Int64 seat_id = 0;
        public Int64 number = 0;
        public Int64 row = 0;
        public Int64 salon_id = 0; //Should this be a salon class?

        public seat(Int64 seat_id, Int64 number, Int64 row, Int64 salon_id)
        {
            this.seat_id = seat_id;
            this.number = number;
            this.row = row;
            this.salon_id = salon_id;
        }

    }
}
