using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    sealed class HotelManager
    {
        private HotelManager instance = null;
        public HotelManager getInstance()
        {
            if (instance == null)
                instance = new HotelManager();
            return instance;
        }

        private HotelManager()
        {

        }
        public

        public void CallRowChief()
        {

        }
    }
}