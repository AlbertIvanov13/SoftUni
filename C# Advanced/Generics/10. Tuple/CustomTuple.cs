﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class CustomTuple<T1, T2>
    {
		private T1 item1;
		private T2 item2;

        public CustomTuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
			this.item2 = item2;
        }
        public T1 Item1
		{
			get { return item1; }
			set { item1 = value; }
		}


		public T2 Item2
		{
			get { return item2; }
			set { item2 = value; }
		}


	}
}