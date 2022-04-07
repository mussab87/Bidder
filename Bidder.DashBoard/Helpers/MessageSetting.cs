using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Bidder.Business.Data;

namespace Bidder.DashBoard.Helpers
{
    public class MessageSetting
    {

        private readonly BidderDataContext _context;
        public MessageSetting(BidderDataContext context)
        {
            _context = context;
        }

        public async Task SendMessageAsync()
        {

            //""966508085456"",
            //     ""966550589777"",
            //     ""966555865665""
            try
            {
                var baseAddress = new Uri("https://www.msegat.com");
                using var httpClient = new HttpClient { BaseAddress = baseAddress };
                {
                    using (var content = new StringContent(@"{
                 ""userName"": ""Dalbarrak@live.com"",
                 ""userSender"": ""Modernsol"",
                 ""apiKey"": ""23a3c312e67f663e1f177223a29484fc"",
                 ""msg"": ""Hi {var1}, Your current balance is {var2} SubUp System  "",
                 ""numbers"": [
                 ""966544085112"",
                 ""966505483449""
                

  ],
  ""vars"": [
    {
      ""var1"": ""every one"",
      ""var2"": ""3000000 $""
    },
    {
      ""var1"": ""vvvvvv"",
      ""var2"": ""bbbbbbbbb""}
  ]
}", System.Text.Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("/gw/sendVars.php", content))
                        {
                            string responseHeaders = response.Headers.ToString();
                            string responseData = await response.Content.ReadAsStringAsync();

                            Console.WriteLine("Status " + (int)response.StatusCode);
                            Console.WriteLine("Headers " + responseHeaders);
                            Console.WriteLine("Data " + responseData);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }
        public string ToKsaKeyNumber(string number)
        {
           string newNumber= number.Remove(0, 1);
            return "966" + newNumber;
        }
    }
}
