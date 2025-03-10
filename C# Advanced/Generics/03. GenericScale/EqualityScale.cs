﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
            AreEqual();
        }

        public bool AreEqual()
        {
            if (left.Equals(right))
            {
                return true;
            }
            return default;
        }
    }
}