using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext()
        {
        }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ppowellSchoolDb";
            optionsBuilder.UseSqlServer(myconnectionstring);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(Get<StudentMap,Student>("CsvReaderExample2023.StudentList1.csv").ToArray());
        }

        public static List<T> Get<U,T>(string resourceName) where U : ClassMap where T : class
        {
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {   // create a stream reader
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    { HasHeaderRecord = true, HeaderValidated=null, MissingFieldFound=null };
                    // create a csv reader dor the stream
                    CsvReader csvReader = new CsvReader(reader, configuration);
                    csvReader.Context.RegisterClassMap<U>();
                    return csvReader.GetRecords<T>().ToList();
                }
            }
        }


        //public static List<T> Get<U, T>(string resourceName) where U : ClassMap where T : class
        //{
        //    {
        //        using (StreamReader reader = new StreamReader(resourceName, Encoding.UTF8))
        //        {
        //            CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        //            { HasHeaderRecord = true };
        //            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
        //            csvReader.Context.RegisterClassMap<U>();
        //            return csvReader.GetRecords<T>().ToList();
        //        }
        //    }
        //}
    }
}
