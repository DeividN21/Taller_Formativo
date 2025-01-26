using DesignPatterns.Models;
using System;
using System.Drawing;


namespace DesignPatterns.NewFolder
{
    // Patrón Builder
    // Clase para setear las variables que se va pedir en el constructor
    // Se añade la variable de año actual
    public class CarModelBuilder
    {
        private string color = "red";
        private string brand = "Ford";
        private string model = "Mustang";
        private int year = DateTime.Now.Year;

        // Se crean seters que retornar ModelBuilder
        public CarModelBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }
        public CarModelBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }
        public CarModelBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }
        public CarModelBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }

        // Método para constuir el objeto
        public Vehicle Build()
        {
            return new Car(color, brand, model, year);
        }
    }
}
