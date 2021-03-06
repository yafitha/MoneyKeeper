﻿using MoneyKepper_Core.Models;
using Models;
using MoneyKepper_Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKepperCore.Service
{
    public class ActionService : IActionsService
    {
        public INavigationService NavigationService { get; private set; }
        public ActionService(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        public void ShowTransactionsDetails(Action<TransactionItem> addCallBack, Action<TransactionItem> removeCallBack, DateTime currentMonth)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("AddCallBack", addCallBack);
            args.Add("RemoveCallBack", removeCallBack);
            args.Add("CureentMonth", currentMonth);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.TRANSACTION_DETAILS, args);
        }

        public void ShowCategoriesDetails(Action<Category> addCallBack, Action<Category> removeCallBack)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("AddCallBack", addCallBack);
            args.Add("RemoveCallBack", removeCallBack);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.CATEGORYDETAILS, args);
        }

        public void ShowHistoryGraphs(DateTime startDateTime, DateTime endDateTime, List<Category> Categories, Graph graphType)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("StartDateTime", startDateTime);
            args.Add("EndDateTime", endDateTime);
            args.Add("GraphType", graphType);
            args.Add("Categories", Categories);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.HISTORY_Details, args);
        }
        public void ShowEmptyPage()
        {
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.EMPTY_PAGE);
        }

        public void ShowMonthGraphs(DateTime month)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("Month", month);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.GRAPHS_DETAILS, args);
        }

        public void ShowReportDetails(DateTime startDateTime, DateTime endDateTime ,string subTitle ="")
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("StartDateTime", startDateTime);
            args.Add("EndDateTime", endDateTime);
            args.Add("SubTitle", subTitle);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.REPORT_DETAILS, args);
        }

        public void ShowBugetDetails(Action<BugetItem> addCallBack, Action<BugetItem> removeCallBack, Action<Tuple<BugetItem, double>> updateCallBack, DateTime month)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("AddCallBack", addCallBack);
            args.Add("RemoveCallBack", removeCallBack);
            args.Add("UpdateCallBack", updateCallBack);
            args.Add("Month", month);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.BUGET_DETAILS, args);
        }
    }
}
