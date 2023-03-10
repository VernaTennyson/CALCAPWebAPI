using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace WebCalCAP
{
    public class CalCAPDataContext : SqlServerDataContext
	{
        public CalCAPDataContext(string connectionString)
            : this(new SqlServerDataContextOptions<CalCAPDataContext>(connectionString))
        {
        }

        public CalCAPDataContext(IDataContextOptions<CalCAPDataContext> options)
            : base(options)
        {
        }
        
        public CalCAPDataContext(IDataContextOptions options)
            : base(options)
        {
        }
    }
}
