using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataCollection
    {
        private const string PrizesFile = "PrizeModels.csv";



        // TODO - Wire up the CreatePrize for the text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to list<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find the max id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new id (max + 1)
            prizes.Add(model);
            
            // Convert the prizes to a list of string
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
