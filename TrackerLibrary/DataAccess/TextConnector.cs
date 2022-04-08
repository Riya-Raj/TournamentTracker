using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataCollection
    {
        // TODO - Wire up the CreatePrize for the text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to list<PrizeModel>
            // Find the max id
            // Add the new record with the new id (max + 1)
            // Convert the prizes to a list of string
            // Save the list<string> to the text file
        }
    }
}
