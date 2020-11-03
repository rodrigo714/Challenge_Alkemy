namespace Challenge_Alkemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notebook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Contenido = c.String(),
                        Imagen = c.Binary(),
                        Categoria = c.Int(nullable: false),
                        Fecha_Creacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
            DropTable("dbo.Categorias");
        }
    }
}
