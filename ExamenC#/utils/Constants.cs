namespace ExamenC_.utils
{
    public class Constants
    {

        // API Constants
        public const string BASE_URL_API = "https://pokeapi.co/api/v2/";
        public const string CUSTOM_OBJECT_API = "pokemon";

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
        public const string ErrorLogFile = "Errors.log";
    }
}
