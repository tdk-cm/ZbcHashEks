using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZbcHashEks.Login.Models;

namespace ZbcHashEks.Login.Data
{
    internal class DatabaseProcessor
    {
        string FolderPath { get; set; }
        string UsersCsvName = "Users.csv";
        public DatabaseProcessor()
        {
            string baseDir = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\"));
            FolderPath = Path.Combine(baseDir, "ZbcHashEks/Login/Data/Database");
        }

        public UserModel GetUserData(string userName)
        {
            List<UserModel> allUsers = LoadUsersData();

            UserModel found = allUsers.Find(x => x.UserName == userName);

            // If not found, it just returns null
            return found;
        }

        public void AddToUsers(List<UserModel> users)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            using (var stream = File.Open(Path.Combine(FolderPath, UsersCsvName), FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(users);
            }
        }

        public void AddToUsers(UserModel user)
        {
            if(!File.Exists(Path.Combine(FolderPath, UsersCsvName)))
            {
                using (File.Create(Path.Combine(FolderPath, UsersCsvName)))
                {

                };
            }

            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };

                using (var stream = File.Open(Path.Combine(FolderPath, UsersCsvName), FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.NextRecord();
                    csv.WriteRecord<UserModel>(user);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }


        public List<UserModel> LoadUsersData()
        {
            try
            {
                using (var reader = new StreamReader(Path.Combine(FolderPath, UsersCsvName)))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<UserModel>();

                    return Enumerable.ToList(records);
                }
            }
            catch (Exception ex)
            {               
                return null;
            }

        }
    }
}
