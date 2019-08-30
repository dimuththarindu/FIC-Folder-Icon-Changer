using System;

namespace FIC
{
    class Payment
    {
        public void Donate()
        {
            try
            {
                string url = "";

                string business = "DimuthTharindu@mail.com";
                string description = "Donation to FIC - Help us to develop the program";
                string country = "US";
                string currency = "USD";

                url += "https://www.paypal.com/cgi-bin/webscr" +
                    "?cmd=" + "_donations" +
                    "&business=" + business +
                    "&lc=" + country +
                    "&item_name=" + description +
                    "&currency_code=" + currency +
                    "&bn=" + "PP%2dDonationsBF";

                System.Diagnostics.Process.Start(url);
            }
            catch (Exception)
            {
            }            
        }
    }
}
