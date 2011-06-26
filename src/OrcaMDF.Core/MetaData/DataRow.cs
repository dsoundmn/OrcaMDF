using System.Collections.Generic;

namespace OrcaMDF.Core.MetaData
{
	public class DataRow : Row
	{
		protected DataRow(IList<DataColumn> columns)
			: base(columns)
		{ }

		public DataRow()
		{ }

		public override Row NewRow()
		{
			return new DataRow(Columns);
		}
	}
}