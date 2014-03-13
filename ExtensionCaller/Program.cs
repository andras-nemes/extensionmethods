using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods.Extensions.Basics;
using ExtensionMethods.Extensions.Enumerations;
using ExtensionMethods.Extensions.Interfaces;

namespace ExtensionCaller
{
	class Program
	{
		static void Main(string[] args)
		{
			string customDateFormat = DateTime.Now.ToCustomFormat();
			Console.WriteLine(customDateFormat);
			string fullName = "Elvis Presley";
			int birthYear = 1935;
			string nickName = "King of Rock and Roll";			
			string email = fullName.ToEmail(nickName, birthYear);

			string xmlName = fullName.ToXmlName();
			string xmlName2 = fullName.ToXmlName("singer");

			IProductDataSource productDataSource = new DatabaseSource();
			IEnumerable<Product> products = productDataSource.SearchProduct("f");

			Console.WriteLine(email);

			TestCollectionExtensions();
			TestObjectExtensions();
			TestTypeExtensions();
			TestPrivateField();
			TestEnumerationExtension();
			try
			{
				TestExceptionExtension(0);
			}
			catch (Exception ex)
			{
				String messages = ex.UserFriendlyFullMessage();
				Console.WriteLine(messages);
			}
			Console.ReadKey();
		}

		private static void TestEnumerationExtension()
		{
			string val = Difficulty.Easy.ToUserFriendlyString();
			string desc = Difficulty.Easy.GetDetailedDescription();
		}

		private static void TestExceptionExtension(int divideBy)
		{
			try
			{
				int res = 10 / divideBy;
			}
			catch (Exception ex)
			{
				InvalidOperationException ioex = new InvalidOperationException("What are you doing???", ex);
				string errorMessage = string.Concat("Division failed. Tried to divide by ", divideBy);
				throw new ApplicationException(errorMessage, ioex);
			}
		}

		private static void TestCollectionExtensions()
		{
			IProductDataSource[] dataSources = new IProductDataSource[] { new DatabaseSource(), new FileSource(), new ApiSource() };
			string searchTerm = "f";

			IEnumerable<Product> productsWithId = dataSources.GetAllItemsByName(searchTerm);
		}

		private static void TestObjectExtensions()
		{
			Product p = new Product() { Id = 1, Name = "product" };
			int i = 5;
			string s = "hello";
			DateTime now = DateTime.UtcNow;
			string xmlProduct = p.ToXmlRepresentation();			
			string integerXml = i.ToXmlRepresentation();
			string stringXml = s.ToXmlRepresentation();
			string dateXml = now.ToXmlRepresentation();
		}

		private static void TestTypeExtensions()
		{
			Product p = new Product() { Id = 1, Name = "product" };
			int i = 5;
			string s = "hello";
			DateTime now = DateTime.UtcNow;
			string productMetadata = p.GetType().GetTypeMetadata();
			string integerMetadata = i.GetType().GetTypeMetadata();
			string stringMetadata = s.GetType().GetTypeMetadata();
			string dateMetadata = now.GetType().GetTypeMetadata();
		}

		private static void TestPrivateField()
		{
			Product p = new Product();
			string privateField = p.DoSomethingWithPrivateField();
		}
	}
}
