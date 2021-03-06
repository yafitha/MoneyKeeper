﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;
using MoneyKepperServer.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using MoneyKepperServer;

namespace UnitTest.UnitTests
{
    [TestClass]
    public class CategoriesUnitTest
    {
        [TestMethod]
        public void GetAllCategories()
        {
            // Arrange
            var controller = new CategoryController();
            controller.Request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://localhost:63840/api/Category/")
            };
            AutoMapperConfiguration.Configure();
            controller.Configuration = new HttpConfiguration();
            controller.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            controller.RequestContext.RouteData = new HttpRouteData(
                route: new HttpRoute(),
                values: new HttpRouteValueDictionary { { "controller", "Category" } });

            // Act
          //  return controller.GetAllCategories();

            // Assert
        }

        [TestMethod]
        public void UpdateCategory(Category category)
        {
            // Arrange
            var controller = new CategoryController();
            controller.Request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://localhost:63840/api/Category/")
            };
            AutoMapperConfiguration.Configure();
            controller.Configuration = new HttpConfiguration();
            controller.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            controller.RequestContext.RouteData = new HttpRouteData(
                route: new HttpRoute(),
                values: new HttpRouteValueDictionary { { "controller", "Category" } });

            // Act
            //var categories = controller.GetAllCategories();
            //var cat = categories[0];
            //cat.PictureName = "6";
            //cat.Name = "yafit";
            var response = controller.UpdateCategory(new Models.Category()) ;

            // Assert
        }
    }
}
