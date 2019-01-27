using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluUntBistro
{
    /// <summary>
    /// Static class for processing Emails in the data base. Holds the logic for getting, deleting and updating the data base. 
    /// </summary>
    public static class EmailProcessor
    {
        /// <summary>
        /// Satic method that retrives all emailaddresses in the data base.
        /// </summary>
        /// <returns>A list of EmailModel objects</returns>
        public static List<EmailModel> LoadEmailAddresses()
        {
            string sql = @"SELECT Id, Email FROM dbo.EmailAddresses;";

            return SQLDataAccess.LoadData<EmailModel>(sql);
        }
    }
}
