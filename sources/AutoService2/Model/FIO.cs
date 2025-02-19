using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService2.Model
{

    ///<summary>
    /// ФИО
    ///</summary>
    public class FIO
    {
        ///<summary>
        /// Фамилия
        ///</summary>
        public string F { get; set; }
        ///<summary>
        /// Имя
        ///</summary>
        public string I { get; set; }
        ///<summary>
        /// Отчество
        ///</summary>
        public string O { get; set; }

        public FIO(string Fname, string Lname, string Patronymic) 
        {
            F = Fname;
            I = Lname;
            O = Patronymic;
        }

        public override string ToString()
        {
            return $"{F} {I} {O}";
        }
    }
}
