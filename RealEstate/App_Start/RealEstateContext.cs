using MongoDB.Driver;
using RealEstate.Properties;

namespace RealEstate.App_Start
{
	public class RealEstateContext
	{
		public MongoDatabase Database;

		public RealEstateContext()
		{
			var client = new MongoClient(Settings.Default.RealEstateConnectionString);
			MongoServer server = client.GetServer();
			Database = server.GetDatabase(Settings.Default.RealEstateDatabaseName);
		}
	}
}