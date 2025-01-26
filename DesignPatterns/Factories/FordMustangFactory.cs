using DesignPatterns.Models;
using DesignPatterns.NewFolder;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder().Build();
        }
    }
}
