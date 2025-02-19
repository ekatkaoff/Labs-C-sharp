using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService2.Model
{
    ///<summary>
    /// Описание основного класса Заявки
    ///</summary>
    public class Items
    {
        private static int _lastId = 0;

        public int id { get; }

        public DateTime DateAdd { get; set; } = DateTime.Now;

        public TypeCar Type { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public FIO FIO { get; set; }

        public string Phone { get; set; }

        public State State { get; set; }

        public Items()
        {
            id = ++_lastId;
        }

    }
}
