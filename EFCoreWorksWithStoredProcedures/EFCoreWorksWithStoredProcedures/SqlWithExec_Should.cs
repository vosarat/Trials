using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EFCoreWorksWithStoredProcedures
{
	[TestClass]
	public class SqlWithExec_Should
	{
		[TestMethod]
		public void MapProcedureResultWithoutPrimaryKeys()
		{
			using (var dbContext = new BloggingContext())
			{
				var result = dbContext.Query<GetBlogDetailsResult>().FromSql("EXEC [dbo].[GetBlogDetails] 1").ToList();
				Assert.AreEqual("http://blogs.msdn.com/dotnet - FirstPost", result.Single().Details);
			}
		}
	}
}
