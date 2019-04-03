using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// when setting your public class SqlConnector 'ctrl+.' gives shortcut to 
    /// quickly implement interface. Until that, you'll have an error
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        ///TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// creates a new method, called CreatePrize
        /// takes in a PrizeModel, and returns a PrizeModel called model
        /// saving a new prize to the databse.
        /// >>same as your IdataConnection prizeModel createModel<<
        /// <param name="model"> The prize information. </param>
        /// <returns>The prize information, including the unique identifier. </returns>
     
        
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
