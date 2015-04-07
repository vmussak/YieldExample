using System.Collections.Generic;
using Yield.Models;
 
namespace Yield 
{ 
    public static class Iterator
    {
        public static IEnumerable<Client> GetYield()
        {
            for (var i = 0; i < 10000000; i++)
                yield return new Client(i, "First Name", "Last Name", 10);
        }

        public static IEnumerable<Client> GetDefault()
        {
            var clientList = new List<Client>();
            for (var i = 0; i < 10000000; i++)
                clientList.Add(new Client(i, "First Name", "Last Name", 10));

            return clientList;
        }
    } 
}





