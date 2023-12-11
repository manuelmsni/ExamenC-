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
            CustomObject result = null;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
                {
                    conn.Open();
                    MySqlCommand mySqlCommand = conn.CreateCommand();
                    mySqlCommand.CommandText = $"SELECT {Constants.COLUMN_FOR_ID}, {Constants.COLUMN_FOR_NAME} FROM {Constants.TABLE_NAME} WHERE {Constants.COLUMN_FOR_ID} = @id";
                    mySqlCommand.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new CustomObject
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
        public bool UpdateObject(CustomObject obj)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
                {
                    conn.Open();
                    MySqlCommand mySqlCommand = conn.CreateCommand();
                    mySqlCommand.CommandText = $"UPDATE {Constants.TABLE_NAME} SET {Constants.COLUMN_FOR_NAME} = @name WHERE {Constants.COLUMN_FOR_ID} = @id";
                    mySqlCommand.Parameters.AddWithValue("@name", obj.Name);
                    mySqlCommand.Parameters.AddWithValue("@id", obj.Id);

                    int rowsAffected = mySqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public bool UpsertObject(CustomObject obj)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
                {
                    conn.Open();
                    MySqlCommand selectCommand = conn.CreateCommand();
                    selectCommand.CommandText = $"SELECT {Constants.COLUMN_FOR_ID}, {Constants.COLUMN_FOR_COUNT} FROM {Constants.TABLE_NAME} WHERE {Constants.COLUMN_FOR_ID} = @id";
                    selectCommand.Parameters.AddWithValue("@id", obj.Id);

                    int currentCount = 0;

                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentCount = reader.GetInt32(1);
                        }
                    }

                    if (currentCount > 0)
                    {
                        MySqlCommand updateCommand = conn.CreateCommand();
                        updateCommand.CommandText = $"UPDATE {Constants.TABLE_NAME} SET {Constants.COLUMN_FOR_COUNT} = @count WHERE {Constants.COLUMN_FOR_ID} = @id";
                        updateCommand.Parameters.AddWithValue("@count", currentCount + 1);
                        updateCommand.Parameters.AddWithValue("@id", obj.Id);
                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand insertCommand = conn.CreateCommand();
                        insertCommand.CommandText = $"INSERT INTO {Constants.TABLE_NAME} ({Constants.COLUMN_FOR_ID}, {Constants.COLUMN_FOR_COUNT}) VALUES (@id, 1)";
                        insertCommand.Parameters.AddWithValue("@id", obj.Id);
                        insertCommand.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
