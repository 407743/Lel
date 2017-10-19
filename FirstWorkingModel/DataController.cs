using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWorkingModel
{
    class DataController
    {
        private static DataController m_getInstance;
        public static DataController getInstance()
        {
            if(m_getInstance == null)
            {
                m_getInstance = new DataController();
            }
            return m_getInstance;
        }
    }
}
