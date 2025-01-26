using DesignPatterns.Models;
using DesignPatterns.NewFolder;

namespace DesignPatterns.Factories
{
    // En el método Create se puede reutilizar el builder antes creado
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .Build();
        }
    }
}
