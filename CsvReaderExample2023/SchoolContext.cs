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

namespace Week4.Console
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext()
        {
        }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ppowellSchoolDb";
            optionsBuilder.UseSqlServer(myconnectionstring);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(Get<Student>("CsvReaderExample2023.StudentList1.csv").ToArray());
        }

        public static List<T> Get<T>(string resourceName)
        {
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {   // create a stream reader
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    { HasHeaderRecord = false };
                    // create a csv reader dor the stream
                    CsvReader csvReader = new CsvReader(reader, configuration);
                    return csvReader.GetRecords<T>().ToList();
                }
            }
        }
    }
}
