using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFID_EX_ETC_Client.Utils;
using RFID_EX_ETC_Client.Model.Enitys;
using RFID_EX_ETC_Client.Model.Remote;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using RFID_EX_ETC_Client.Model;

namespace AppUnitTest {
    [TestClass]
    public class AppUnitTest {
        [TestMethod]
        public void TestMethod1() {
            UnitTest.TestGetCarInfoAsync();
        }

        [TestMethod]
        public void TestMethod2() {
            UnitTest.TestGetRouteInfoAsync();
        }

        [TestMethod]
        public void TestMethod3() {
            UnitTest.TestGetToll();
        }

        [TestMethod]
        public void TestMethod4() {
            UnitTest.TestGetHistoryRouteInfo();
        }

        [TestMethod]
        public void TestMethod5() {
            UnitTest.TestPostRouteInfo();
        }
    } 
};