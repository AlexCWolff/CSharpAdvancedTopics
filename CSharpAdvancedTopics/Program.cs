namespace CSharpAdvancedTopics
{   
    class Program 
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\temp\\LOG.txt"));
            dbMigrator.Migrate();
        }
    }
}