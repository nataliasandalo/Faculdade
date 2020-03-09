namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Aniversario = c.DateTime(nullable: false),
                        CodigoInscricao = c.Int(nullable: false),
                        Professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .Index(t => t.Professor_Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Aniversario = c.DateTime(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DisciplinaFaculdade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaFaculdades", t => t.DisciplinaFaculdade_Id)
                .Index(t => t.DisciplinaFaculdade_Id);
            
            CreateTable(
                "dbo.DisciplinaFaculdades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CursoFaculdade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CursoFaculdades", t => t.CursoFaculdade_Id)
                .Index(t => t.CursoFaculdade_Id);
            
            CreateTable(
                "dbo.CursoFaculdades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Notas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aluno_Id = c.Int(),
                        Professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunoes", t => t.Aluno_Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .Index(t => t.Aluno_Id)
                .Index(t => t.Professor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notas", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Notas", "Aluno_Id", "dbo.Alunoes");
            DropForeignKey("dbo.Alunoes", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Professors", "DisciplinaFaculdade_Id", "dbo.DisciplinaFaculdades");
            DropForeignKey("dbo.DisciplinaFaculdades", "CursoFaculdade_Id", "dbo.CursoFaculdades");
            DropIndex("dbo.Notas", new[] { "Professor_Id" });
            DropIndex("dbo.Notas", new[] { "Aluno_Id" });
            DropIndex("dbo.DisciplinaFaculdades", new[] { "CursoFaculdade_Id" });
            DropIndex("dbo.Professors", new[] { "DisciplinaFaculdade_Id" });
            DropIndex("dbo.Alunoes", new[] { "Professor_Id" });
            DropTable("dbo.Notas");
            DropTable("dbo.CursoFaculdades");
            DropTable("dbo.DisciplinaFaculdades");
            DropTable("dbo.Professors");
            DropTable("dbo.Alunoes");
        }
    }
}
