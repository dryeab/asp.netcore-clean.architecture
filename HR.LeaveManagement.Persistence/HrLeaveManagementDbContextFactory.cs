using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HR.LeaveManagement.Persistence
{
    public class HrLeaveManagementDbContextFactory : IDesignTimeDbContextFactory<HrLeaveManagementDbContext>
    {

        public HrLeaveManagementDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory() + "/../HR.LeaveManagement.Api")
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<HrLeaveManagementDbContext>();
            var connectionString = configurationRoot.GetConnectionString("LeaveManagementConnectionString");
            
            builder.UseNpgsql(connectionString);
            return new HrLeaveManagementDbContext(builder.Options);
        }
    }
}

