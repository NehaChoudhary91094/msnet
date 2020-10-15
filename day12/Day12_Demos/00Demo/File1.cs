using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
	//Automat ically generated code?
    public partial class Emp
    {
		partial void Validate(string propertyName, object Value);

		private int _Age;

		public int Age
		{
			get { return _Age; }
			set 
			{
				Validate("Age", value);
				_Age = value;
			}
		}

	}
}
