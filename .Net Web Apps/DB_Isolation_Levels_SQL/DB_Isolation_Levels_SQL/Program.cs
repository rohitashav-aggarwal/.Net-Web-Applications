using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; //will attach to any type of database
//OLE does not need to change commands in program for different databases

namespace DB_Isolation_Levels_SQL
{
    class Program
    {
        static void Main(string[] args)
        {//see connectionstrings.com for database connections
            OleDbConnection c = new OleDbConnection(@" ");
            //see isolation level types
            //to control how SQL works
            OleDbTransaction t = c.BeginTransaction(System.Data.IsolationLevel.Snapshot);
            Console.ReadKey();
        }
    }
}
