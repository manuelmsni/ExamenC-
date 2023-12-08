using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.utils
{
    internal class Constants
    {
        // API Constants
        public const string BASE_URL_API = "";

        // DATABASE Constants
        public const string CONNECTION_STRING = "server=localhost;" +
                                                "port=8888;" +
                                                "uid=root;" +
                                                "pwd=my-secret-pw;" +
                                                "database=Country;";

        public const string TABLE_NAME = "MostVisited";
        public const string COLUMN_FOR_ID = "id";
        public const string COLUMN_FOR_NAME = "name";

        // Other
    }
}
