using System;
using System.Data.SqlClient;

namespace KURSPROJESON
{
    internal class Sqlconnection
    {
        public Sqlconnection(string myconnstr)
        {
        }

        public static implicit operator Sqlconnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}