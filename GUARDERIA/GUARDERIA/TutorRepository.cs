using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GUARDERIA
{
    public class TutorRepository : ITutorRepository
    {
        private readonly string connectionString = @"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true";

        public void EliminarTutor(string id)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string baja = "DELETE FROM TUTOR WHERE ID_TUTOR=@ID_TUTOR";
                SqlCommand cmd = new SqlCommand(baja, conexion);
                cmd.Parameters.AddWithValue("@ID_TUTOR", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
