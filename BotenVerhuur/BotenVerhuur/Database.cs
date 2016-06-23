using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace BotenVerhuur
{
    public class Database
    {
        public string ConnectionString { get; protected set; } = "User Id=dbi346087;Password=Tram123;DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";
        public OracleConnection Connection { get; protected set; }
        public Database(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new OracleConnection(connectionString);
        }

        private void OpenConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {
                Console.WriteLine("A connection could not be opened.");
            }
        }
        private void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public List<Boot> GetBoten()
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("SELECT B.ID, B.NAAM, T.PRIJS, T.TANKINHOUD FROM BV_BOOT B, BV_TYPE T WHERE B.TYPEID = T.ID", Connection);
            OracleDataReader reader = cmd.ExecuteReader();
            List<Boot> boten = new List<Boot>();

            while (reader.Read())
            {
                Boot boot = new Boot(
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["NAAM"]),
                    Convert.ToDouble(reader["PRIJS"]),
                    Convert.ToInt32(reader["TANKINHOUD"])
                    );
                boten.Add(boot);
            }
            CloseConnection();
            return boten;
        }

        public List<Artikel> GetArktikelen()
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("SELECT * FROM BV_ARTIKEL", Connection);
            OracleDataReader reader = cmd.ExecuteReader();
            List<Artikel> artikelen = new List<Artikel>();

            while (reader.Read())
            {
                Artikel artikel = new Artikel(
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["NAAM"]),
                    Convert.ToDouble(reader["PRIJS"]));
                artikelen.Add(artikel);
            }
            CloseConnection();
            return artikelen;
        }

        public List<Water> GetWateren()
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("SELECT * FROM BV_WATEREN", Connection);
            OracleDataReader reader = cmd.ExecuteReader();
            List<Water> wateren = new List<Water>();

            while (reader.Read())
            {
                bool motorNodig = false;
                if (Convert.ToInt32(reader["MOTORNODIG"]) == 1)
                {
                    motorNodig = true;
                }
                Water water = new Water(
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["NAAM"]),
                    Convert.ToDouble(reader["PRIJS"]),
                    motorNodig);
                wateren.Add(water);
            }
            CloseConnection();
            return wateren;
        }
        public void AddHuurder(Huurder huurder)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("INSERT INTO BV_HUURDER (NAME, EMAIL) VALUES('" + huurder.naam + "', '" + huurder.email + "');", Connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void AddHuurcontract(Huurcontract huurcontract)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("INSERT INTO BV_HUURCONTRACT(HUURDERID, STARTDATE, ENDDATE) VALUES("+ huurcontract.huurder.ID + ", " + ToOracleDate(huurcontract.StartDate) + ", " + ToOracleDate(huurcontract.EndDate) + ");" , Connection);
            cmd.ExecuteNonQuery();
            foreach (Artikel artikel in huurcontract.artikelen)
            {
             OracleCommand cmd2 = new OracleCommand("INSERT INTO BV_HUURCONTRACT_ARTIKEL (");   
            }
            CloseConnection();
        }

        public bool CheckEmail(string email)
        {
            OpenConnection();
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM BV_HUURDER WHERE EMAIL ='" + email + "';",Connection);
            try
            {
                int EmailExist = (int) cmd.ExecuteScalar();
                if (EmailExist > 0)
                {
                    return true;
                }
                return false;
            }
            catch (OracleException)
            {
                //er is iets mis met oracle, deze methode werkt niet goed.
                return true;
            }

        }

                public string ToOracleDate(DateTime date)
        {
            return "TO_DATE('" + string.Format("{0:dd-MMM-yy}", date) + "', 'DD-MON-YY')";
        }
    }
}
