using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxCSharpLibrary;

namespace MaxCSharpLibraryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStringWithStringPreAndStringPost()
        {
            string expectedResult = "Apple";

            string input = "Plese give me that [Apple] on your hand.";

            string result = input.StringBetweenFirstOccurence("that [", "] on your");

            Assert.IsTrue(result == expectedResult, String.Format("Expected for '{0}': true; Actual: '{1}'", expectedResult, result));
        }
        [TestMethod]
        public void TestEpsFileListCase()
        {
            string expectedResult = @"1.[CBPC190926.pgp][1124][2019/09/26 19:22:02]
2.[CBPC190927.pgp][1124][2019/09/27 19:23:05]
3.[CBPC190928.pgp][1121][2019/09/28 19:17:05]
4.[CBPC190929.pgp][1124][2019/09/29 19:24:36]
5.[CBPC190930.pgp][1122][2019/09/30 19:22:36]
6.[CBPC191001.pgp][1125][2019/10/01 19:20:58]
7.[CBPC191002.pgp][1121][2019/10/02 19:22:30]
8.[CBPC191003.pgp][1126][2019/10/03 19:20:29]
9.[CBPC191004.pgp][1125][2019/10/04 19:21:07]
10.[CBPC191005.pgp][1123][2019/10/05 19:22:31]
11.[CBPC191006.pgp][1122][2019/10/06 19:20:56]
12.[CBPC191007.pgp][1125][2019/10/07 19:17:55]
13.[CBPC191008.pgp][1192][2019/10/08 19:21:03]
14.[CBPC191009.pgp][1124][2019/10/09 19:20:54]";

            string input = @"C:\Users\s0896\source\repos\ilrcnewoms_finance_upgrade\ILRCNewOms\EPS\EPS -700000903>atv -L -Mailbox ephp3623 && echo READY
List File(s)
MailBox: ephp3623
[File Name][Size][Creation Date]
1.[CBPC190926.pgp][1124][2019/09/26 19:22:02]
2.[CBPC190927.pgp][1124][2019/09/27 19:23:05]
3.[CBPC190928.pgp][1121][2019/09/28 19:17:05]
4.[CBPC190929.pgp][1124][2019/09/29 19:24:36]
5.[CBPC190930.pgp][1122][2019/09/30 19:22:36]
6.[CBPC191001.pgp][1125][2019/10/01 19:20:58]
7.[CBPC191002.pgp][1121][2019/10/02 19:22:30]
8.[CBPC191003.pgp][1126][2019/10/03 19:20:29]
9.[CBPC191004.pgp][1125][2019/10/04 19:21:07]
10.[CBPC191005.pgp][1123][2019/10/05 19:22:31]
11.[CBPC191006.pgp][1122][2019/10/06 19:20:56]
12.[CBPC191007.pgp][1125][2019/10/07 19:17:55]
13.[CBPC191008.pgp][1192][2019/10/08 19:21:03]
14.[CBPC191009.pgp][1124][2019/10/09 19:20:54]

----------List 14 file(s) completed----------
READY";

            string result = input.StringBetweenFirstOccurence($"Creation Date]{Environment.NewLine}", $"{Environment.NewLine}{Environment.NewLine}----------");

            Assert.IsTrue(result == expectedResult, String.Format("Expected for '{0}': true; Actual: '{1}'", expectedResult, result));
        }
        [TestMethod]
        public void TestMultipleEndString()
        {
            String expectedResult = "0008450";

            String input = "F: CBPC191011, I: 0008450, M: 700000903, S: 950, T: 002, Seq: 000002";

            string result = input.StringBetweenFirstOccurence("I: ",",");

            Assert.IsTrue(result == expectedResult, String.Format("Expected for '{0}': true; Actual: '{1}'", expectedResult, result));
        }
    }
}
