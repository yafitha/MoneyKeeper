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

        public void ShowTransactionsDetails(Action<Tuple<TransactionsViewModel.Types, double>> addCallBack, Action<Tuple<TransactionsViewModel.Types, double>> removeCallBack)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("AddCallBack", addCallBack);
            args.Add("RemoveCallBack", removeCallBack);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.TRANSACTION_DETAILS, args);
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

        public void ShowMonthGraphs(DateTime startDateTime, DateTime endDateTime, Graph graphType)
        {
            Dictionary<string, object> args = new Dictionary<string, object>();
            args.Add("StartDateTime", startDateTime);
            args.Add("EndDateTime", endDateTime);
            args.Add("GraphType", graphType);
            this.NavigationService.DetailsFrame.NavigateTo(NavigationPageKeys.GRAPHS_DETAILS, args);
        }
    }
}