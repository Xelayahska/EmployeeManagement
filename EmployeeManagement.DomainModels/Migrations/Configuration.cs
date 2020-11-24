﻿namespace EmployeeManagement.DomainModels.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagement.DomainModels.EmpDbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EmployeeManagement.DomainModels.EmpDbcontext";
        }

        protected override void Seed(EmployeeManagement.DomainModels.EmpDbcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}