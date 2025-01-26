using DesignPatterns.Models;
using DesignPatterns.NewFolder;

namespace DesignPatterns.Factories
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Explorer")
                .setColor("black")
                .Build();
        }
    }
}
