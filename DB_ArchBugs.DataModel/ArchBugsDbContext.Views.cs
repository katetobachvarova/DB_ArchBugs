//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(DB_ArchBugs.DataModel.ArchBugsDbContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets7041038336bfae5af668be023630fa9f294a8ace9f384c664226c89492834f66))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySets7041038336bfae5af668be023630fa9f294a8ace9f384c664226c89492834f66 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "7041038336bfae5af668be023630fa9f294a8ace9f384c664226c89492834f66"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.BugReport")
            {
                return GetView0();
            }

            if (extentName == "CodeFirstDatabase.Location")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.User")
            {
                return GetView2();
            }

            if (extentName == "ArchBugsDbContext.BugReports")
            {
                return GetView3();
            }

            if (extentName == "ArchBugsDbContext.Locations")
            {
                return GetView4();
            }

            if (extentName == "ArchBugsDbContext.Users")
            {
                return GetView5();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.BugReport.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing BugReport
        [CodeFirstDatabaseSchema.BugReport](T1.BugReport_Id, T1.BugReport_Name, T1.BugReport_Description, T1.BugReport_SeverityType, T1.BugReport_LocationId, T1.BugReport_UserId)
    FROM (
        SELECT 
            T.Id AS BugReport_Id, 
            T.Name AS BugReport_Name, 
            T.Description AS BugReport_Description, 
            CAST(T.SeverityType AS [Edm.Int32]) AS BugReport_SeverityType, 
            T.LocationId AS BugReport_LocationId, 
            T.UserId AS BugReport_UserId, 
            True AS _from0
        FROM ArchBugsDbContext.BugReports AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Location.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Location
        [CodeFirstDatabaseSchema.Location](T1.Location_Id, T1.Location_Description, T1.Location_X, T1.Location_Y)
    FROM (
        SELECT 
            T.Id AS Location_Id, 
            T.Description AS Location_Description, 
            T.X AS Location_X, 
            T.Y AS Location_Y, 
            True AS _from0
        FROM ArchBugsDbContext.Locations AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.User.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User
        [CodeFirstDatabaseSchema.User](T1.User_Id, T1.User_Name, T1.User_Email)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            T.Email AS User_Email, 
            True AS _from0
        FROM ArchBugsDbContext.Users AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ArchBugsDbContext.BugReports.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing BugReports
        [DB_ArchBugs.DataModel.BugReport](T1.BugReport_Id, T1.BugReport_Name, T1.BugReport_Description, T1.BugReport_SeverityType, T1.BugReport_LocationId, T1.BugReport_UserId)
    FROM (
        SELECT 
            T.Id AS BugReport_Id, 
            T.Name AS BugReport_Name, 
            T.Description AS BugReport_Description, 
            CAST(T.SeverityType AS [DB_ArchBugs.DataModel.BugReportSeverityType]) AS BugReport_SeverityType, 
            T.LocationId AS BugReport_LocationId, 
            T.UserId AS BugReport_UserId, 
            True AS _from0
        FROM CodeFirstDatabase.BugReport AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ArchBugsDbContext.Locations.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Locations
        [DB_ArchBugs.DataModel.Location](T1.Location_Id, T1.Location_Description, T1.Location_X, T1.Location_Y)
    FROM (
        SELECT 
            T.Id AS Location_Id, 
            T.Description AS Location_Description, 
            T.X AS Location_X, 
            T.Y AS Location_Y, 
            True AS _from0
        FROM CodeFirstDatabase.Location AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ArchBugsDbContext.Users.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Users
        [DB_ArchBugs.DataModel.User](T1.User_Id, T1.User_Name, T1.User_Email)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            T.Email AS User_Email, 
            True AS _from0
        FROM CodeFirstDatabase.User AS T
    ) AS T1");
        }
    }
}
