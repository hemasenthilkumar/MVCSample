﻿namespace MVCSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {

            Sql("Update MembershipTypes set Name='Pay as you Go' where Id=1");
            Sql("Update MembershipTypes set Name='Monthly' where Id=2");
            Sql("Update MembershipTypes set Name='Quaterly' where Id=3");
            Sql("Update MembershipTypes set Name='Anually' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
