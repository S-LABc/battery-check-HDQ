namespace Consoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string strValue = "65535";
            //string strValue = "1";
            //string strValue = "-1";
            //string strValue = "-32768";
            //string strValue = "-32767";
            //65380-156
            string[] numbers = { "65380","1", "32767", "32768", "32769", "32770", "65535","-1", "-65535","655356456" };

            foreach (var arg in numbers) { Convert(arg); }



        }

        private static void Convert(string strValue)
        {
            if (int.TryParse(strValue, out int intValue))
            {
                // Integer değeri 2 bayta çevirme
                byte[] bytes = BitConverter.GetBytes((short)intValue);

                //if (BitConverter.IsLittleEndian)
                //{
                //    // Küçük endian (little-endian) sistemler için baytları ters çevirme
                //    Array.Reverse(bytes);
                //}

                // 2 baytlık bayttan işaretli short sayıya dönüştürme
                short shortValue = BitConverter.ToInt16(bytes, 0);

                Console.WriteLine("Başlangıç String Değeri: " + strValue);
                Console.WriteLine("Integer Değer: " + intValue);
                Console.WriteLine("2 Baytlık Bayt Dizisi: " + BitConverter.ToString(bytes));
                Console.WriteLine("İşaretli Short Sayı: " + shortValue);
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Geçerli bir integer değeri değil.");
                Console.WriteLine("");
            }
        }
    }
}