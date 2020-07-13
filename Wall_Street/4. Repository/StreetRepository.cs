using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;

namespace Wall_Street.Repository
{
	public class StreetRepository
	{
		CorporateName Service = CorporateName.Service;
		CorporateName RealEstate = CorporateName.RealEstate;
		CorporateName Forest = CorporateName.Forest;
		CorporateName Pharma = CorporateName.Pharma;
		CorporateName Electric = CorporateName.Electric;
		CorporateName Finance = CorporateName.Finance;


		private List<Street> createServiceStreetList()
		{
			var streetList = new List<Street>();
			var street1 = new Street { StreetID = 1, StreetName = "Painting", StreetPrice = 5000, RentPriceWithoutBuilding = 0, RentPriceWithBuilding = 10000, BuildingCost = 10000, StreetDividend = 10000 };
			var street2 = new Street { StreetID = 2, StreetName = "Office", StreetPrice = 10000, RentPriceWithoutBuilding = 0, RentPriceWithBuilding = 20000, BuildingCost = 20000, StreetDividend = 10000 };
			var street3 = new Street { StreetID = 3, StreetName = "Carpentry", StreetPrice = 15000, RentPriceWithoutBuilding = 5000, RentPriceWithBuilding = 25000, BuildingCost = 15000, StreetDividend = 10000 };
			streetList.Add(street1);
			streetList.Add(street2);
			streetList.Add(street3);
			return streetList;

		}


		private List<Street> createRealEstateStreetList()
		{
			var streetList = new List<Street>();

			return streetList;

		}
		private List<Street> createForestStreetList()
		{
			var streetList = new List<Street>();

			return streetList;

		}
		private List<Street> createPharmaStreetList()
		{
			var streetList = new List<Street>();

			return streetList;

		}
		private List<Street> createElectricStreetList()
		{
			var streetList = new List<Street>();

			return streetList;

		}
		private List<Street> createFinanceStreetList()
		{
			var streetList = new List<Street>();

			return streetList;

		}


		public List<CorporateGroup> createCorporateGroups()
		{
			var streetList = new List<Street>();
			var serviceStreetList = createServiceStreetList();
			var corporateGroupList = new List<CorporateGroup>();
			var serviceGroup = new CorporateGroup { CorporateID = 1, CorporateName = Service, Streets = serviceStreetList };
			var realEstateGroup = new CorporateGroup { CorporateID = 2, CorporateName = RealEstate, Streets = streetList };
			var forestGroup = new CorporateGroup { CorporateID = 3, CorporateName = Forest, Streets = streetList };
			var pharmaGroup = new CorporateGroup { CorporateID = 4, CorporateName = Pharma, Streets = streetList };
			var electricGroup = new CorporateGroup { CorporateID = 5, CorporateName = Electric, Streets = streetList };
			var financeGroup = new CorporateGroup { CorporateID = 6, CorporateName = Finance, Streets = streetList };

			corporateGroupList.Add(serviceGroup);
			corporateGroupList.Add(realEstateGroup);
			corporateGroupList.Add(forestGroup);
			corporateGroupList.Add(pharmaGroup);
			corporateGroupList.Add(electricGroup);
			corporateGroupList.Add(financeGroup);

			return corporateGroupList;
		}
	}
}
