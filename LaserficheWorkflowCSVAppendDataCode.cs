//The rest of the code appends each row current value's token passed to the specified headers.
namespace WorkflowActivity.Scripting.AppendOnceOffValues
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.IO;//Remember to add this namespace to your code when printing anything to a file.

    /// <summary>
    /// Provides one or more methods that can be run when the workflow scripting activity is performed.
    /// </summary>
    public class Script1 : ScriptClass90
    {
        /// <summary>
        /// This method is run when the activity is performed.
        /// </summary>
        protected override void Execute()
        {
            //Variables generally defined as strings to make exporting easier and formatting of data less tedious
            //Some examples below:
            var Description = (string) (GetTokenValue("Description"));
            var QuoteNumber = (string) (GetTokenValue("QuoteNumber"));

            //Commas, line breaks and some other extreme cases generally breaks the CSV.
            //Compensate for these either in your Workflow or in your code here like below:
            if (Description.Contains(","))
            {
                Description = Description.Replace ("," , ".");
            }

            string text = Description+","+QuoteNumber+"\r\n";
            File.AppendAllText("C:\\Your\\Path\\Here\\YourCSVDocumentName.csv", text);
        }
    }
}