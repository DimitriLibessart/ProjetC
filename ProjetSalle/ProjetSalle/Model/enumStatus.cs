using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model
{
    enum EnumStatus
    {
        Clean, //table free and clear but nothing on it
        Used, //Clients on the table
        Soiled,
        Dirty, //Client left but table still dirty
        Ready //ready to be used by clients
    }
}