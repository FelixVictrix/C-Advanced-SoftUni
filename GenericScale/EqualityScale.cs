﻿namespace GenericScale
{
    public class EqualityScale<T>
    where T : class 
    {
        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T Left { get; set; }
        public T Right { get; set; }
        
        public bool AreEqual() => Left == Right; //Left.Equals(Right);

         
    }
}
