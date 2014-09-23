using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using LogicNP.CryptoLogger;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace NPLoggerSample
{
    public class Sample1
    {
        private readonly Logger _logger;

        public Sample1()
        {
            var debug = false;
            _logger = new Logger("NPLoggerSample");
            _logger.Enabled = true;
            _logger.LoadSettings("nplogger.xml");
            if (debug) _logger.MainSession.Level = LogEntryLevel.Debug;
        }

        public void LogTest()
        {
            var m = _logger.MainSession.EnterMethod(GetCurrentMethod());
            _logger.MainSession.LogDateTime("DateTimeValue_Now",DateTime.Now);
            _logger.MainSession.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            _logger.MainSession.LogDebug("LogDebug");
            _logger.MainSession.LogInt("test Integer",20);
            _logger.MainSession.LogString("myName","Ivan Nausley");
            _logger.MainSession.LogNormal("LogNormal");
            _logger.MainSession.LogInt("test Integer", 20);
            _logger.MainSession.LogString("myName", "Ivan Nausley");
            m.Dispose();
        }

        public void LogTestImbedded()
        {
            var m = _logger.MainSession.EnterMethod(GetCurrentMethod());
            _logger.MainSession.LogDateTime("DateTimeValue_Now", DateTime.Now);
            _logger.MainSession.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            _logger.MainSession.LogDebug("LogDebug");
            _logger.MainSession.LogInt("test Integer", 20);
            _logger.MainSession.LogString("myName", "Ivan Nausley");
            _logger.MainSession.LogNormal("LogNormal");
            _logger.MainSession.LogInt("test Integer", 20);
            _logger.MainSession.LogString("myName", "Ivan Nausley");
            LogTest1();
            
            LogTest2();
            m.Dispose();
        }

        public void DebugSession()
        {
            var s = _logger.GetSession("Debug");
            var m = s.EnterMethod(GetCurrentMethod());
            s.LogDateTime("DateTimeValue_Now", DateTime.Now);
            s.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            s.LogDebug("LogDebug");
            s.LogInt("test Integer", 20);
            s.LogString("myName", "Ivan Nausley");
            s.LogNormal("LogNormal");
            s.LogInt("test Integer", 20);
            s.LogString("myName", "Ivan Nausley");
            m.Dispose();
        }


        public void PossibleException(int a, int b)
        {
            var log = _logger.MainSession;
            var m = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            try
            {
                log.LogInt("a",a);
                log.LogInt("b",b);
                var result = (double) a / b;
                log.LogDouble("Divide Result",result);
                log.LogSeparator();
                m.Dispose();
            }
            catch (Exception e)
            {
                log.LogException(e);
                //log.LogException(e.InnerException);
                m.Dispose();
                //throw new DivideByZeroException();
            }
        }

        public void Objects()
        {
            var n1 = new Customer();
            var n2 = new Customer();
            var log = _logger.MainSession;
            var m = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);

            n1.Name = "Ivan Nausley";
            n1.Address = "426 N Rosevere";
            n1.City = "Dearborn";
            n1.State = "Michigan";
            n1.ZipCode = "48128";

            log.LogObject("n1 Object - Ivan",n1);

            n2.Name = "Brock Coffee";
            n2.Address = "45207 Helm Street";
            n2.City = "Plymouth";
            n2.State = "Michigan";
            n2.ZipCode = "48170";

            log.LogObject("n2 Object - Brock", n2);
            log.LogSeparator();
            m.Dispose();
        }


 
        public void ListObjects()
        {
            var n1 = new Customer();
            var n2 = new Customer();
            var log = _logger.MainSession;
            var myList = new List<Customer>();
            var m = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            log.LogSystemInformation();
            n1.Name = "Ivan Nausley";
            n1.Address = "426 N Rosevere";
            n1.City = "Dearborn";
            n1.State = "Michigan";
            n1.ZipCode = "48128";
            myList.Add(n1);

            log.LogObject("n1 Object - Ivan", n1);

            n2.Name = "Brock Coffee";
            n2.Address = "45207 Helm Street";
            n2.City = "Plymouth";
            n2.State = "Michigan";
            n2.ZipCode = "48170";
            myList.Add(n2);
            log.LogObject("n2 Object - Brock", n2);
            log.LogString("myList of Objects", JsonConvert.SerializeObject(myList));
            log.LogSeparator();
            m.Dispose();
        }

        public void ListUIDs()
        {
            var log = _logger.MainSession;
            var m = log.EnterMethod(GetCurrentMethod());
            var myList = new List<Guid>();
            myList.Add(Guid.NewGuid());
            myList.Add(Guid.NewGuid());
            myList.Add(Guid.NewGuid());
            myList.Add(Guid.NewGuid());
            log.LogInt("Count",myList.Count);
            log.LogList("myList",myList);
            log.LogString("myList - JSON",JsonConvert.SerializeObject(myList));
            log.LogSeparator();
            m.Dispose();

        }

        public void MongoObjects()
        {
            IDisposable loopDisposable;
            var mongoClient = new MongoClient("mongodb://localhost");
            var mongoServer = mongoClient.GetServer();
            var db = mongoServer.GetDatabase("nplogger");
            var collection = db.GetCollection<Customer>("Customers");
            var n1 = new Customer();
            var n2 = new Customer();
            var log = _logger.MainSession;
            var m = log.EnterMethod(GetCurrentMethod());
            var myList = new List<Customer>();
            log.LogDateTime("DateTimeValue_UTC", DateTime.UtcNow);
            log.LogSystemInformation();
            n1.Name = "Ivan Nausley";
            n1.Address = "426 N Rosevere";
            n1.City = "Dearborn";
            n1.State = "Michigan";
            n1.ZipCode = "48128";
            myList.Add(n1);

            log.LogObject("n1 Object - Ivan", n1);

            n2.Name = "Brock Coffee";
            n2.Address = "45207 Helm Street";
            n2.City = "Plymouth";
            n2.State = "Michigan";
            n2.ZipCode = "48170";
            myList.Add(n2);
            log.LogObject("n2 Object - Brock", n2);
            
            log.LogMessage("Start database tests");
            collection.Save(n1);
            collection.Save(n2);
            log.LogMessage("Read database test");

            var result1 = collection.AsQueryable().FirstOrDefault(d => d.Name == "Brock Coffee");
            log.LogObject("result1", result1);

            var resultList = collection.FindAllAs<Customer>();
            log.LogList("resultList - LIST",resultList);
            log.LogString("resultList - JSON",JsonConvert.SerializeObject(resultList));
            using (var p = log.EnterMethod("resultList foreach loop"))
            {
                foreach (var customer in resultList)
                {
                    log.LogObject("customer Object",customer);
                }
            }

            using (var p = log.EnterMethod("resultList foreach loop 2"))
            {
                foreach (var customer in resultList)
                {
                    log.LogObject("customer Object",customer);
                }
            }

            log.LogSeparator();
            m.Dispose();

        }

        public void SQLObjects()
        {
            
        }

        #region Private Methods

        private void LogTest1()
        {
            var log = _logger.MainSession;
            var x = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_Now", DateTime.Now);
            log.LogDouble("Double Value",3.1415);
            LogTest1A();
            x.Dispose();

        }

        private void LogTest2()
        {
            var log = _logger.MainSession;
            var lm = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_Now", DateTime.Now);
            lm.Dispose();
        }

        private void LogTest1A()
        {
            var log = _logger.MainSession;
            var lm = log.EnterMethod(GetCurrentMethod());
            log.LogDateTime("DateTimeValue_Now", DateTime.Now);
            lm.Dispose();

        }

        private string GetCurrentMethod()
        {
            var st = new StackTrace();
            return st.GetFrame(1).GetMethod().Name;
        }
        #endregion
    }
}
