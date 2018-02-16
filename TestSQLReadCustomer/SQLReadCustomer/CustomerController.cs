using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SQLReadCustomer;

namespace SQLReadCustomer
{
    public class CustomerController
    {
        public bool Delete(Customer customer)
        {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The connection did not open.");
                return false;
            }
            string sql = "Delete from customer where id = 9;";

            SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlParameter psearch = new SqlParameter("@search", search);
            ////SqlParameter pupper = new SqlParameter("@uppercl", upper);
            //cmd.Parameters.Add(psearch);
            cmd.Parameters.Add(new SqlParameter("@Id", customer.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", customer.Name));
            cmd.Parameters.Add(new SqlParameter("@City", customer.City));
            cmd.Parameters.Add(new SqlParameter("@State", customer.State));
            cmd.Parameters.Add(new SqlParameter("@IsCorpAcct", customer.IsCorpAcct));
            cmd.Parameters.Add(new SqlParameter("@CreditLimit", customer.CreditLimit));
            cmd.Parameters.Add(new SqlParameter("@Active", customer.Active));
            int recsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (recsAffected != 1)
            {
                Console.WriteLine("Delete failed. Blame [insert intern name].");
                return false;
            }
            return true;
        }
        public bool Update(Customer customer)
        {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The connection did not open.");
                return false;
            }
            string sql = "update customer set name = @Name, city = @City, state = @State, IsCorpAcct = @IsCorpAcct, CreditLimit = @CreditLimit, Active = @Active, where id = @id;";

            SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlParameter psearch = new SqlParameter("@search", search);
            ////SqlParameter pupper = new SqlParameter("@uppercl", upper);
            //cmd.Parameters.Add(psearch);
            cmd.Parameters.Add(new SqlParameter("@Name", customer.Name));
            cmd.Parameters.Add(new SqlParameter("@City", customer.City));
            cmd.Parameters.Add(new SqlParameter("@State", customer.State));
            cmd.Parameters.Add(new SqlParameter("@IsCorpAcct", customer.IsCorpAcct));
            cmd.Parameters.Add(new SqlParameter("@CreditLimit", customer.CreditLimit));
            cmd.Parameters.Add(new SqlParameter("@Active", customer.Active));
            int recsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (recsAffected != 1)
            {
                Console.WriteLine("Insert failed. Blame [insert intern name].");
                return false;
            }
            return true;
        }

        public bool Insert(Customer customer) {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The connection did not open.");
                return false;
            }
            string sql = "insert into customer"
                                + "(name, city, state, IsCorpAcct, CreditLimit, Active)" +
                            "values(@Name, @City, @State, @IsCorpAcct, @CreditLimit, @Active);";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlParameter psearch = new SqlParameter("@search", search);
            ////SqlParameter pupper = new SqlParameter("@uppercl", upper);
            //cmd.Parameters.Add(psearch);
            cmd.Parameters.Add(new SqlParameter("@Name", customer.Name));
            cmd.Parameters.Add(new SqlParameter("@City", customer.City));
            cmd.Parameters.Add(new SqlParameter("@State", customer.State));
            cmd.Parameters.Add(new SqlParameter("@IsCorpAcct", customer.IsCorpAcct));
            cmd.Parameters.Add(new SqlParameter("@CreditLimit", customer.CreditLimit));
            cmd.Parameters.Add(new SqlParameter("@Active", customer.Active));
            int recsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (recsAffected != 1)
            {
                Console.WriteLine("Insert failed. Blame [insert intern name].");
            return false;
            }
            return true;
        }

        //public List<Customer> SearchByName(string search)
        //{
        //    string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
        //    SqlConnection conn = new SqlConnection(connStr);
        //    conn.Open();
        //    if (conn.State != System.Data.ConnectionState.Open)
        //    {
        //        Console.WriteLine("The connection did not open.");
        //        return null;
        //    }
        //    string sql =  "SELECT * from customer"
        //                    + " where name like '%' +@search+ '%'"
        //                    + " order by name;";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlParameter psearch = new SqlParameter("@search", search);
        //    //SqlParameter pupper = new SqlParameter("@uppercl", upper);
        //    cmd.Parameters.Add(psearch);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (!reader.HasRows)
        //    {
        //        Console.WriteLine("Result has no row.");
        //        return null;
        //    }

        //    List<Customer> customers = new List<Customer>();
        //    while (reader.Read())
        //    {
        //        int id = reader.GetInt32(reader.GetOrdinal("Id"));
        //        string name = reader.GetString(reader.GetOrdinal("Name"));
        //        string city = reader.GetString(reader.GetOrdinal("city"));
        //        string state = reader.GetString(reader.GetOrdinal("state"));
        //        bool isCorpAcct = reader.GetBoolean(reader.GetOrdinal("IsCorpAcct"));
        //        int creditLimit = reader.GetInt32(reader.GetOrdinal("CreditLimit"));
        //        bool active = reader.GetBoolean(reader.GetOrdinal("Active"));

        //        Customer customer = new Customer();
        //        customer.Id = id;
        //        customer.Name = name;
        //        customer.City = city;
        //        customer.State = state;
        //        customer.IsCorpAcct = isCorpAcct;
        //        customer.CreditLimit = creditLimit;
        //        customer.Active = active;
        //        customers.Add(customer);
        //    }
        //    conn.Close();
        //    return customers;
        //}

        public List<Customer> SearchByCreditLimitRange(int lower, int upper)
        {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The connection did not open.");
                return null;
            }
            string sql = "select * from customer"
                + "where creditlimit between @lowercl and @uppercl"
                + "order by creditlimit";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter plower = new SqlParameter("@lowercl", lower);
            SqlParameter pupper = new SqlParameter("@uppercl", upper);
            cmd.Parameters.Add(plower);
            cmd.Parameters.Add(pupper);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                Console.WriteLine("Result has no row.");
                return null;
            }
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                string name = reader.GetString(reader.GetOrdinal("Name"));
                string city = reader.GetString(reader.GetOrdinal("city"));
                string state = reader.GetString(reader.GetOrdinal("state"));
                bool isCorpAcct = reader.GetBoolean(reader.GetOrdinal("IsCorpAcct"));
                int creditLimit = reader.GetInt32(reader.GetOrdinal("CreditLimit"));
                bool active = reader.GetBoolean(reader.GetOrdinal("Active"));

                Customer customer = new Customer();
                customer.Id = id;
                customer.Name = name;
                customer.City = city;
                customer.State = state;
                customer.IsCorpAcct = isCorpAcct;
                customer.CreditLimit = creditLimit;
                customer.Active = active;
                customers.Add(customer);
            }
            conn.Close();
            return customers;
        }

        public Customer Get(int CustomerId)
        {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The connection did not open.");
                return null;
            }
            string sql = "select * from customer where id = id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = CustomerId;
            cmd.Parameters.Add(pId);
            cmd.Parameters.Add(pId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                Console.WriteLine($"Customer {CustomerId} not found");
                return null;
            }
            //oh no, copied code}

            reader.Read();
            int id = reader.GetInt32(reader.GetOrdinal("Id"));
            string name = reader.GetString(reader.GetOrdinal("Name"));
            string city = reader.GetString(reader.GetOrdinal("city"));
            string state = reader.GetString(reader.GetOrdinal("state"));
            bool isCorpAcct = reader.GetBoolean(reader.GetOrdinal("IsCorpAcct"));
            int creditLimit = reader.GetInt32(reader.GetOrdinal("CreditLimit"));
            bool active = reader.GetBoolean(reader.GetOrdinal("Active"));

            Customer customer = new Customer();
            customer.Id = id;
            customer.Name = name;
            customer.City = city;
            customer.State = state;
            customer.IsCorpAcct = isCorpAcct;
            customer.CreditLimit = creditLimit;
            customer.Active = active;

            conn.Close();
            return customer;
        }

        public List<Customer> List()
        {
            string connStr = @"server=STUDENT06\SQLEXPRESS;database=SqlTutorial;Trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            // always check that your connection is open
            // always check that your connection terminates
            {
                Console.WriteLine("The connection did not open.");
                return null;
            }
            string sql = "select * from customer";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                Console.WriteLine("Result has no row.");
                return null;

            }
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                string name = reader.GetString(reader.GetOrdinal("Name"));
                string city = reader.GetString(reader.GetOrdinal("city"));
                string state = reader.GetString(reader.GetOrdinal("state"));
                bool isCorpAcct = reader.GetBoolean(reader.GetOrdinal("IsCorpAcct"));
                int creditLimit = reader.GetInt32(reader.GetOrdinal("CreditLimit"));
                bool active = reader.GetBoolean(reader.GetOrdinal("Active"));

                Customer customer = new Customer();
                customer.Id = id;
                customer.Name = name;
                customer.City = city;
                customer.State = state;
                customer.IsCorpAcct = isCorpAcct;
                customer.CreditLimit = creditLimit;
                customer.Active = active;

                customers.Add(customer);

                // Console.WriteLine($"Name is {name}");
            }
            conn.Close();
            return customers;
        }
    }
}
        
