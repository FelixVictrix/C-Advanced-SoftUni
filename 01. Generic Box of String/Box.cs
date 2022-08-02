namespace _01._Generic_Box_of_String
{
    public class Box<T>
    {
        private T text;

        public Box(T text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return this.text.ToString();
        }
    }
}
