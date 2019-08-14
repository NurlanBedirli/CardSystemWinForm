namespace BankLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserMessage = c.String(),
                        PersonId = c.Int(nullable: false),
                        RepaymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Repayments", t => t.RepaymentId, cascadeDelete: true)
                .Index(t => t.RepaymentId);
            
            CreateTable(
                "dbo.CardDefaults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                        CardNumber = c.String(),
                        CardType = c.String(),
                        ExpireDeath = c.DateTime(nullable: false),
                        CVC = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "bank.Card",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                        CardHolder = c.String(),
                        CardType = c.String(),
                        CardNumber = c.String(maxLength: 14),
                        CVC = c.Int(nullable: false),
                        Balance = c.Decimal(precision: 8, scale: 2),
                        ExpireDeath = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("bank.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "bank.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "bank.PhoneNumber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberPhone = c.String(),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("bank.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "bank.Internet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AbuneKodu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Repayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RepaymentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddMessages", "RepaymentId", "dbo.Repayments");
            DropForeignKey("bank.PhoneNumber", "PersonId", "bank.People");
            DropForeignKey("bank.Card", "PersonId", "bank.People");
            DropIndex("bank.PhoneNumber", new[] { "PersonId" });
            DropIndex("bank.Card", new[] { "PersonId" });
            DropIndex("dbo.AddMessages", new[] { "RepaymentId" });
            DropTable("dbo.Repayments");
            DropTable("bank.Internet");
            DropTable("bank.PhoneNumber");
            DropTable("bank.People");
            DropTable("bank.Card");
            DropTable("dbo.CardDefaults");
            DropTable("dbo.AddMessages");
        }
    }
}
