using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;

namespace Wall_Street.Repository
{
	
	public class BanksStocksFundsRepository
	{
		#region Italia Bank Funds and Stocks
		public List<Fund> CreateItaliaFundList()
		{
			var fundList = new List<Fund>();
			var italiaFundOne = new Fund { FundID = 1, FundCost = 10000, FundDividend = 65000 };
			var italiaFundTwo = new Fund { FundID = 2, FundCost = 10000, FundDividend = 65000 };
			var italiaFundThree = new Fund { FundID = 3, FundCost = 10000, FundDividend = 65000 };
			var italiaFundFour = new Fund { FundID = 4, FundCost = 10000, FundDividend = 65000 };
			var italiaFundFive = new Fund { FundID = 5, FundCost = 10000, FundDividend = 65000 };
			var italiaFundSix = new Fund { FundID = 6, FundCost = 10000, FundDividend = 65000 };
			fundList.Add(italiaFundOne);
			fundList.Add(italiaFundTwo);
			fundList.Add(italiaFundThree);
			fundList.Add(italiaFundFour);
			fundList.Add(italiaFundFive);
			fundList.Add(italiaFundSix);
			return fundList;			
		}
	
		public List<Stock> CreateItaliaStockList()
		{
			var stockList = new List<Stock>();
			var italiaStockOne = new Stock { StockID = 1, StockCost = 5000, StockDividend = 10000, StockNumber = 1 };
			var italiaStockTwo = new Stock { StockID = 2, StockCost = 10000, StockDividend = 10000, StockNumber = 2 };
			var italiaStockThree = new Stock { StockID = 3, StockCost = 15000, StockDividend = 20000, StockNumber = 3};
			var italiaStockFour = new Stock { StockID = 4, StockCost = 20000, StockDividend = 20000, StockNumber = 4 };
			var italiaStockFive = new Stock { StockID = 5, StockCost = 30000, StockDividend = 30000, StockNumber = 5 };
			var italiaStockSix = new Stock { StockID = 6, StockCost = 50000, StockDividend = 50000, StockNumber = 6 };
			stockList.Add(italiaStockOne);
			stockList.Add(italiaStockTwo);
			stockList.Add(italiaStockThree);
			stockList.Add(italiaStockFour);
			stockList.Add(italiaStockFive);
			stockList.Add(italiaStockSix);
			return stockList;
		}
		#endregion

		#region London Bank Funds and Stocks
		public List<Fund> CreateLondonFundList()
		{
			var fundList = new List<Fund>();
			var londonFundOne = new Fund { FundID = 7, FundCost = 20000, FundDividend = 75000 };
			var londonFundTwo = new Fund { FundID = 8, FundCost = 20000, FundDividend = 75000 };
			var londonFundThree = new Fund { FundID = 9, FundCost = 20000, FundDividend = 75000 };
			var londonFundFour = new Fund { FundID = 10, FundCost = 20000, FundDividend = 75000 };
			var londonFundFive = new Fund { FundID = 11, FundCost = 20000, FundDividend = 75000 };
			var londonFundSix = new Fund { FundID = 12, FundCost = 20000, FundDividend = 75000 };
			fundList.Add(londonFundOne);
			fundList.Add(londonFundTwo);
			fundList.Add(londonFundThree);
			fundList.Add(londonFundFour);
			fundList.Add(londonFundFive);
			fundList.Add(londonFundSix);
			return fundList;
		}

		public List<Stock> CreateLondonStockList()
		{
			var stockList = new List<Stock>();
			var londonStockOne = new Stock { StockID = 7, StockCost = 10000, StockDividend = 10000, StockNumber = 1 };
			var londonStockTwo = new Stock { StockID = 8, StockCost = 15000, StockDividend = 10000, StockNumber = 2 };
			var londonStockThree = new Stock { StockID = 9, StockCost = 20000, StockDividend = 20000, StockNumber = 3 };
			var londonStockFour = new Stock { StockID = 10, StockCost = 25000, StockDividend = 20000, StockNumber = 4 };
			var londonStockFive = new Stock { StockID = 11, StockCost = 35000, StockDividend = 30000, StockNumber = 5 };
			var londonStockSix = new Stock { StockID = 12, StockCost = 60000, StockDividend = 50000, StockNumber = 6 };
			stockList.Add(londonStockOne);
			stockList.Add(londonStockTwo);
			stockList.Add(londonStockThree);
			stockList.Add(londonStockFour);
			stockList.Add(londonStockFive);
			stockList.Add(londonStockSix);
			return stockList;
		}
		#endregion


		public List<Bank> CreateBankList()
		{
			BankName italiaBankName = BankName.ItaliaBank;
			BankName londonBankName = BankName.LondonBank;
			var italiaFundList = CreateItaliaFundList();
			var italiaStockList = CreateItaliaStockList();			
			var bankList = new List<Bank>();
			var italiaBank = new Bank() { BankID = 1, BankName = italiaBankName, Funds = italiaFundList,  Stocks = italiaStockList};

			var londonFundList = CreateLondonFundList();
			var londonStockList = CreateLondonStockList();
			var londonBank = new Bank() { BankID = 2, BankName = londonBankName, Funds = londonFundList, Stocks = londonStockList };

			bankList.Add(italiaBank);
			bankList.Add(londonBank);
			//bankList.Add(monacoBank);
			//bankList.Add(franceBank);
			//bankList.Add(bundesBank);
			//bankList.Add(wallStreetBank);
			return bankList;
		}
	}
}
