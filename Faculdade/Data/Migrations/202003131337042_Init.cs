namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
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
                        ProfessorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.ProfessorId, cascadeDelete: true)
                .Index(t => t.ProfessorId);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Aniversario = c.DateTime(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DisciplinaFaculdadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaFaculdades", t => t.DisciplinaFaculdadeId, cascadeDelete: true)
                .Index(t => t.DisciplinaFaculdadeId);
            
            CreateTable(
                "dbo.DisciplinaFaculdades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CursoFaculdadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CursoFaculdades", t => t.CursoFaculdadeId, cascadeDelete: true)
                .Index(t => t.CursoFaculdadeId);
            
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
                        AlunoId = c.Int(nullable: false),
                        Notas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunoes", t => t.AlunoId, cascadeDelete: true)
                .Index(t => t.AlunoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notas", "AlunoId", "dbo.Alunoes");
            DropForeignKey("dbo.Alunoes", "ProfessorId", "dbo.Professors");
            DropForeignKey("dbo.Professors", "DisciplinaFaculdadeId", "dbo.DisciplinaFaculdades");
            DropForeignKey("dbo.DisciplinaFaculdades", "CursoFaculdadeId", "dbo.CursoFaculdades");
            DropIndex("dbo.Notas", new[] { "AlunoId" });
            DropIndex("dbo.DisciplinaFaculdades", new[] { "CursoFaculdadeId" });
            DropIndex("dbo.Professors", new[] { "DisciplinaFaculdadeId" });
            DropIndex("dbo.Alunoes", new[] { "ProfessorId" });
            DropTable("dbo.Notas");
            DropTable("dbo.CursoFaculdades");
            DropTable("dbo.DisciplinaFaculdades");
            DropTable("dbo.Professors");
            DropTable("dbo.Alunoes");
        }
    }
}
