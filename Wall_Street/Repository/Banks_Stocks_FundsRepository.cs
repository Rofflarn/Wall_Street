using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_Street.Model;

namespace Wall_Street.Repository
{
	
	public class Banks_Stocks_FundsRepository
	{
		
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

		public List<Bank> CreateBankList()
		{
			var fundList = CreateItaliaFundList();
			var stockList = CreateItaliaStockList();
			var bankList = new List<Bank>();
			var italiaBank = new Bank() { BankID = 1, Funds = fundList, BankName = "Italia Bank", Stocks = stockList};

			bankList.Add(italiaBank);
			return bankList;
		}
	}
}
