using ExamenC_.models;
using ExamenC_.utils;
using MySql.Data.MySqlClient;
namespace ExamenC_.dao
{
    public class CustomObjectDAO : DAO<CustomObject>
    {
        public List<CustomObject> GetAll()
        {
            List<CustomObject> buffer = new List<CustomObject> ();
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    MySqlCommand mySqlCommand = conn.CreateCommand();
                    mySqlCommand.CommandText = $"SELECT {Constants.COLUMN_FOR_ID}, {Constants.COLUMN_FOR_NAME} FROM {Constants.TABLE_NAME}";
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        CustomObject temp = new CustomObject
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                          //  Visitas = reader.IsDBNull(2) ? 0 : reader.GetInt32(1)
                        };
                        buffer.Add(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return buffer;
        }
        public bool InsertObject(CustomObject obj)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.ConnectionString = Constants.CONNECTION_STRING;
                    conn.Open();
                    MySqlCommand mySqlCommand = conn.CreateCommand();
                    if (obj.Id == 0)
                    {
                        mySqlCommand.CommandText = $"INSERT INTO {Constants.TABLE_NAME} ({Constants.COLUMN_FOR_NAME}) " +
                            "VALUES (@name);" +
                            "SELECT LAST_INSERT_ID();";
                        mySqlCommand.Parameters.AddWithValue("@name", obj.Name);

                        // Ejecuta el comando y obtiene el ID generado
                        obj.Id = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                        return obj.Id > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
        public CustomObject SelectObject(int id)
        {
            throw new NotImplementedException();
        }
        public bool UpdateObject(CustomObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
