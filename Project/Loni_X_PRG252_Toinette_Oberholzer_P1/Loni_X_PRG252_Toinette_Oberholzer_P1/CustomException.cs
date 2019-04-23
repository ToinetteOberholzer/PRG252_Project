using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    class CustomException:Exception
    {
        public CustomException()
        {

        }

        public CustomException(string message) : base(message)
        {

        }
    }
}
