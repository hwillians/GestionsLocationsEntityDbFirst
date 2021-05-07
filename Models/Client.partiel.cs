using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class CLIENT 
    {
        public override string ToString()
        {
            return string.Format("{0} - {1} {2} ({3}), {4} {5} - {6}",
                ID, NOM, PRENOM, DATE_NAISSANCE.ToString("dd/MM/yy"), ADRESSE, CODE_POSTAL, VILLE);
        }
    }
}
