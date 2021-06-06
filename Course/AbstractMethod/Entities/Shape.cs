using Course.AbstractMethod.Entities.Enums;

namespace Course.AbstractMethod.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape() {  }

        public Shape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();
    }
}
