using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FormUI
{
    public class DataAccess
    {
        private readonly IDbConnection _db;

        public DataAccess(string env = "Default")
        {
            _db = new SqlConnection(Helper.ConnString(env));
        }

        public List<Person> GetPeople(string lastName)
        {
            using (_db)
            {
                var people = _db.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return people;
            }

        }

        public bool InsertPerson(Person newPerson)
        {
            using (_db)
            {
                try
                {
                    _db.Query<Person>("dbo.People_InsertPerson @FirstName, @LastName, @Email, @PhoneNumber",
                        new
                        {
                            FirstName = newPerson.FirstName,
                            LastName = newPerson.LastName,
                            Email = newPerson.EmailAddress,
                            PhoneNumber = newPerson.PhoneNumber
                        });

                    return true;
                }
                catch (DataException e)
                {
                    return false;
                }
                    

                
            }
        }
    }
}
