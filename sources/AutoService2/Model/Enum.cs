using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService2.Model
{
    /// <summary>
    /// Перечисление типов авто
    /// </summary>
    public enum TypeCar
    {
        Compact,
        Sedan,
        SUV,
        Hatchback,
        Coupe
    }

    ///<summary>
    /// Перечисление статусов заявки
    ///</summary>
    public enum State
    {
        New,
        Progress,
        Completed
    }
}
