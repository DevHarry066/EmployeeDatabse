namespace EmployeeDatabse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeContextv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfJoining = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
