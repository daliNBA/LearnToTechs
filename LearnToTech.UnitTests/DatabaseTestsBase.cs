﻿using LearnToTech.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnToTech.UnitTests
{
    /// <summary>Base class for tests that require the SQL Server engine.</summary>
    [TestClass]
    public abstract class DatabaseTestsBase : TestsBase
    {
        protected static DbContextOptions<DatabaseContext> options;

        /// <summary>Called at the start of a test run.</summary>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            // Create a LocalDB database for each test run
            var databaseName = Guid.NewGuid().ToString();
            var connectionString = $"Server=localhost\\SQLEXPRESS;Database={databaseName};Trusted_Connection=True;MultipleActiveResultSets=False";
            options = new DbContextOptionsBuilder<DatabaseContext>().UseSqlServer(connectionString).Options;
            using (var context = new DatabaseContext(options))
                context.Database.Migrate();
        }

        /// <summary>Called at the end of a test run.</summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Delete the LocalDB database
            using (var context = new DatabaseContext(options))
                context.Database.EnsureDeleted();
        }
    }
}
