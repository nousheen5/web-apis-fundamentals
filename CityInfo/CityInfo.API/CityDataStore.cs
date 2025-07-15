using CityInfo.API.Models;

namespace CityInfo.API
{
	public class CityDataStore
	{
		public List<CityDto> Cities { set; get; }
		public static CityDataStore Current {get;}= new CityDataStore();
		public CityDataStore()
		{
			Cities = new List<CityDto>()
						{
								new CityDto()
								{
										 Id = 1,
										 Name = "New York City",
										 Description = "The one with that big park.",
								},
								new CityDto()
								{
										Id = 2,
										Name = "Antwerp",
										Description = "The one with the cathedral that was never really finished.",
										
								},
								new CityDto()
								{
										Id= 3,
										Name = "Paris",
										Description = "The one with that big tower.",
										
								}
						};
		}
	}
}
