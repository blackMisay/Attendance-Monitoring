using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Prototype.Class
{
    class AttendanceController
    {

        string connectionString = "server=127.0.0.1;database=jetexpressglobalph;username=root;password=;";

        /// <summary>
        /// Gets the list of attendance.
        /// </summary>
        /// <returns>Records of attendance</returns>
        public DataTable GetRecordList()
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT AttendanceId,`Name`,Department,WorkId,Position,AttendanceDate,AttendanceTime,PunchTime,Result,AttendanceLocation,Note FROM `attendance`;";

                using (var cmd = new MySqlCommand(query, con))
                {

                    // Setup an adapter and pass the command as argument.
                    var da = new MySqlDataAdapter(cmd);

                    // Declare a datatable that will hold the data from the adapter.
                    var dt = new DataTable();

                    // Pass the data to the declared datatable.
                    da.Fill(dt);

                    // Disose the adapter.
                    da.Dispose();

                    // Return the retrieve data.
                    return dt;
                }
            }
        }

        /// <summary>
        /// Gets the list of attendance by specified tag.
        /// </summary>
        /// <param name="tag">filter value tag</param>
        /// <returns>Records of attendance</returns>
        public DataTable GetRecordListByTag(string tag)
        {
            string query = "SELECT AttendanceId,`Name`,Department,WorkId,Position,AttendanceDate,AttendanceTime,PunchTime,Result,AttendanceLocation,Note FROM `attendance` WHERE `Name` LIKE @tag OR `Department` LIKE @tag OR `WorkId` LIKE @tag OR `AttendanceDevice` LIKE @tag;";

            var args = new Dictionary<string, object> { { "@tag", string.Format("{0}%", tag) } };

            DataTable dt = ExecuteRead(query, args);

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            return dt;
        }

        /// <summary>
        /// Method for reading data from the database.
        /// </summary>
        /// <param name="sql">Sql query.</param>
        /// <param name="paramValue">Dictionary objects for the parameter of the sql.</param>
        /// <returns>A Set of data in the form of DataTable.</returns>
        public DataTable ExecuteRead(string sql, Dictionary<string, object> paramValue)
        {
            // Check wether the sql is null or empty.
            if (string.IsNullOrEmpty(sql.Trim()))
                return null;

            // Connection Setup
            using (var con = new MySqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Setup a new command
                using (var cmd = new MySqlCommand(sql, con))
                {
                    // Iterate through the paramValue, and pass it as a parameter.
                    foreach (KeyValuePair<string, object> entry in paramValue)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                    // Setup an adapter and pass the command as argument.
                    var da = new MySqlDataAdapter(cmd);

                    // Declare a datatable that will hold the data from the adapter.
                    var dt = new DataTable();

                    // Pass the data to the declared datatable.
                    da.Fill(dt);

                    // Disose the adapter.
                    da.Dispose();

                    // Return the retrieve data.
                    return dt;

                }

            }
        }

    }
}
