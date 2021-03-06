﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuiJi.Net.Core.Compile;
using RuiJi.Net.Node.Feed.Db;
using RuiJi.Net.Owin.Controllers;

namespace RuiJi.Net.Test
{
    [TestClass]
    public class CompileTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var url = "http://app.cannews.com.cn/roll.php?do=query&callback=jsonp1475197217819&_={# ticks() #}&date={# now(\"yyyy-MM-dd\") #}&size=20&page={# page(1,10) #}&&start={# limit(1,5,2) #}";

            var f = new UrlCompile();
            var urls = f.GetResult(url);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestSample()
        {
            var m = new FuncModel();
            m.Code = @"for (int i = 0; i < 10; i++)
            {
                result += i.ToString();
            }
            ";
            m.Sample = "timeOfDay()";

            var func = new ComplieFuncTest("result = DateTime.Now.TimeOfDay;");
            var result = func.GetResult("{# " + m.Sample + " #}");

            Assert.IsTrue(result.Length > 0);
        }
    }
}