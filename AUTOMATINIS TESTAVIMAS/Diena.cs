

using NUnit.Framework;

namespace AUTOMATINIS_TESTAVIMAS
{
    internal class Diena
    {

        public void naujas()

        {
            int sk1 = 6;
            int sk2 = 8;
            int expectedResult = 14;

            int actualResult = sk1 + sk2;

            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}

