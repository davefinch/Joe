using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russell
{

    // Jobs so Far
    //2	1	1	De De Payrd De - Leeds Castle, Wedding scenes with dancing.Wife is Mal.https://www.imdb.com/title/tt8647400/	2018-07-02 00:00:00.000	2018-07-03 00:00:00.000	100	10	10	False
    //5	1	2	Key Retirement Plan Advert With dancing.Welsh Centre Russell Square, & Pinner.Partner is a friend of Mal. If you're thinking of releasing equity, then good advice is Key!	2018-07-04 00:00:00.000	2018-07-05 00:00:00.000	100	10	10	False
    //7	1	3	Amazon Prime Advert Shoot - Moorgate    2018-07-13 00:00:00.000	2018-07-14 00:00:00.000	100	10	10	False
    //9	1	4	British Heart Foundation - Audition 2018-07-24 00:00:00.000	2018-07-24 00:00:00.000	100	0	0	False
    //10	1	1	Paddy Power - Kingston  2018-07-26 00:00:00.000	2018-07-26 00:00:00.000	100	10	10	False
    //12	1	2	Warner Bros - Watford Junction	2018-07-31 00:00:00.000	2018-07-31 00:00:00.000	100	10	10	False
    //13	1	3	Cadburys Advert - Wimbledon 2018-08-06 00:00:00.000	2018-08-06 00:00:00.000	100	10	10	False
    //26	1	4	Cadbury launches Premier League with Jamie Redknapp.    2018-08-06 07:55:25.000	2018-08-06 07:55:25.000	100	NULL NULL    False
    //27	1	1	Top Boy series 3 - Mr Ali a Design and Technology  teacher in a Netflix production.Stoke Newington	2018-08-09 07:56:56.000	2018-08-09 07:56:56.000	100	NULL NULL    False
    //23	1	2	Warner Bros - Watford Junction, Day 2	2018-08-14 08:51:58.000	2018-08-14 08:51:58.000	100	NULL NULL    False
    //28    1   1   Natwest Advert - Bromley.   2018-08-15 00:00:00.000	2018-08-15 00:00:00.000	100	10	10	False    
    //29    1   1   Warner Bros - Spiderman Stanstead Airport.   2018-08-16 00:00:00.000	2018-08-16 00:00:00.000	100	10	10	False    
    //
    //
    //
    //
    //
    //Lemsip Advert - Woolwich 29/08/2018
    //Project X - Wimbledon 30/08/2018


    public class DataJob
    {
        public int JobId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string JobDetails { get; set; }
        public DateTime? StartJob { get; set; }
        public DateTime? EndJob { get; set; }
        public bool PaymentReceived { get; set; }
        public decimal TotalPayment { get; set; }



    }
}