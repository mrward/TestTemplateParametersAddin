using System;
$if$ ($AddSystemXml$ == true)using System.Xml;
using System.Xml.Linq;
$else$using System.Linq;
$endif$using System.Text;

namespace ${Namespace}
{
	public class ${Name}
	{
		public ${Name} ()
		{
		}
		$if$ ($AddToStringMethod$ == true)
			public override string ToString ()
		{
			return "${Name}";
		}
		$endif$	}
}