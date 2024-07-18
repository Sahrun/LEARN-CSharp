using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_40_Access_Modifiers_Section_40_5_internal
{
	internal class Foo
	{
		internal string SomeProperty { get; set; }
	}

	internal class Bar
	{
		var myInstance = new Foo();
		internal string SomeField = Foo.SomeProperty;
		internal class Baz
		{
			private string blah;
			public int N { get; set; }
		}
	}
}
