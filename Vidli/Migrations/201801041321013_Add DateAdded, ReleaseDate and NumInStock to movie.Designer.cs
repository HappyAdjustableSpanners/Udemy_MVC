// <auto-generated />
namespace Vidli.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddDateAddedReleaseDateandNumInStocktomovie : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddDateAddedReleaseDateandNumInStocktomovie));
        
        string IMigrationMetadata.Id
        {
            get { return "201801041321013_Add DateAdded, ReleaseDate and NumInStock to movie"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}