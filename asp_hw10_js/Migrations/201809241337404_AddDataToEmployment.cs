namespace asp_hw10_js.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToEmployment : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Employments (Name) VALUES('Cook') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Taxi driver') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Nurse') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Doctor') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Saleman') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Butler') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Progremmer') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Clerk') ");
            Sql(@"INSERT INTO Employments (Name) VALUES('Student') ");
        }
        
        public override void Down()
        {
        }
    }
}
